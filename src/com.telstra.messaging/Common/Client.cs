using System.Net.Http.Json;
using System.Text.Json;
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Utils;
using Newtonsoft.Json.Linq;

namespace com.telstra.messaging.Common;
public abstract class Client
{
    private readonly HttpClient _httpClient;
    private readonly AuthConfig _authConfig;
    private AuthToken? _authToken;

    public Client(Credentials credentials)
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(Constants.BASE_PATH)
        };

        if (credentials.HasValues)
        {
            _authConfig = new AuthConfig(credentials);
        }
        else
        {
            _authConfig = new AuthConfig();
        }
    }

    public async Task<HttpResponseMessage> SendAsync(HttpMethod httpMethod, string path, object? payload = null, QueryParams? queryParams = null)
    {
        //var isReportParams = payload?.GetType().ToString() == "com.telstra.messaging.Models.Reports.CreateReportsParams";
        queryParams = queryParams ?? new QueryParams(10, 0, null);
        // Check AccessToken validitiy
        if (_authToken == null || string.IsNullOrEmpty(_authToken.AccessToken) || _authToken.IsExpired)
        {
            var response = await RenewToken();
            if (!response.IsSuccessStatusCode)
                return response;
        }

        // Build Request
        var msgAPIRequest = new HttpRequestMessage(httpMethod, $"{path}{queryParams.BuildQueryString()}");
        var serializeOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
        };

        if (payload?.GetType().ToString() == "com.telstra.messaging.Models.Reports.CreateReportsParams")
        {
            serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters = { new CustomDateTimeConverter() }
            };
        }

        var requestContent = JsonContent.Create(payload ?? new object(), null, serializeOptions);

        msgAPIRequest.Content = requestContent; //new System.Net.Http.StringContent(payload.ToString(), Encoding.UTF8, "application/json");
        msgAPIRequest.Headers.Add("Telstra-api-version", "3.x");
        msgAPIRequest.Headers.Add("Accept-Charset", "utf-8");
        msgAPIRequest.Headers.Add("Accept", "application/json");
        msgAPIRequest.Content.Headers.Clear();
        msgAPIRequest.Content.Headers.Add("Content-Type", "application/json");
        msgAPIRequest.Content.Headers.Add("Content-Language", "en-au");
        msgAPIRequest.Headers.Add("Authorization", $"Bearer {_authToken?.AccessToken}");

        // Send Request
        var msgAPIResponse = await _httpClient.SendAsync(msgAPIRequest);

        return msgAPIResponse;
    }

    public async Task<HttpResponseMessage> RenewToken()
    {
        HttpRequestMessage msgAPIRequest = new(HttpMethod.Post, "/v2/oauth/token");

        var formData = new Dictionary<string, string>
        {
            { "grant_type", "client_credentials" },
            { "client_id", _authConfig.AuthCredentials.ClientId },
            { "client_secret", _authConfig.AuthCredentials.ClientSecret },
            { "scope", "free-trial-numbers:read free-trial-numbers:write virtual-numbers:read virtual-numbers:write messages:read messaging:write reports:read reports:write" }
        };
        msgAPIRequest.Content = new FormUrlEncodedContent(formData);
        msgAPIRequest.Headers.Add("Accept", "*/*");

        HttpResponseMessage response = await _httpClient.SendAsync(msgAPIRequest);

        if (response.IsSuccessStatusCode)
        {
            var authRespObject = JObject.Parse(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
            var accessToken = authRespObject["access_token"]?.ToString();
            int.TryParse(authRespObject["expires_in"]?.ToString(), out int expiresIn);
            var tokenType = authRespObject["token_type"]?.ToString();

            _authToken = new AuthToken(accessToken ?? string.Empty, tokenType ?? string.Empty, expiresIn);
        }

        return response;
    }
}
