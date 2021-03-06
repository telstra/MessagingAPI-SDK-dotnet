/* 
 * Telstra Messaging API
 *
 *  The Telstra SMS Messaging API allows your applications to send and receive SMS text messages from Australia's leading network operator.  It also allows your application to track the delivery status of both sent and received SMS messages. 
 *
 * OpenAPI spec version: 2.2.4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;

namespace com.telstra.messaging.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Generate authentication token
        /// </summary>
        /// <remarks>
        /// Generate authentication token
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="grantType"></param>
        /// <returns>OAuthResponse</returns>
        OAuthResponse AuthToken (string clientId, string clientSecret, string grantType);

        /// <summary>
        /// Generate authentication token
        /// </summary>
        /// <remarks>
        /// Generate authentication token
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="grantType"></param>
        /// <returns>ApiResponse of OAuthResponse</returns>
        ApiResponse<OAuthResponse> AuthTokenWithHttpInfo (string clientId, string clientSecret, string grantType);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Generate authentication token
        /// </summary>
        /// <remarks>
        /// Generate authentication token
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="grantType"></param>
        /// <returns>Task of OAuthResponse</returns>
        System.Threading.Tasks.Task<OAuthResponse> AuthTokenAsync (string clientId, string clientSecret, string grantType);

        /// <summary>
        /// Generate authentication token
        /// </summary>
        /// <remarks>
        /// Generate authentication token
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="grantType"></param>
        /// <returns>Task of ApiResponse (OAuthResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthResponse>> AuthTokenAsyncWithHttpInfo (string clientId, string clientSecret, string grantType);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthenticationApi : IAuthenticationApi
    {
        private com.telstra.messaging.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = com.telstra.messaging.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.telstra.messaging.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public com.telstra.messaging.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Generate authentication token Generate authentication token
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="grantType"></param>
        /// <returns>OAuthResponse</returns>
        public OAuthResponse AuthToken (string clientId, string clientSecret, string grantType)
        {
             ApiResponse<OAuthResponse> localVarResponse = AuthTokenWithHttpInfo(clientId, clientSecret, grantType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate authentication token Generate authentication token
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="grantType"></param>
        /// <returns>ApiResponse of OAuthResponse</returns>
        public ApiResponse< OAuthResponse > AuthTokenWithHttpInfo (string clientId, string clientSecret, string grantType)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling AuthenticationApi->AuthToken");
            // verify the required parameter 'clientSecret' is set
            if (clientSecret == null)
                throw new ApiException(400, "Missing required parameter 'clientSecret' when calling AuthenticationApi->AuthToken");
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling AuthenticationApi->AuthToken");

            var localVarPath = "/oauth/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clientId != null) localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (clientSecret != null) localVarFormParams.Add("client_secret", Configuration.ApiClient.ParameterToString(clientSecret)); // form parameter
            if (grantType != null) localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OAuthResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthResponse)));
        }

        /// <summary>
        /// Generate authentication token Generate authentication token
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="grantType"></param>
        /// <returns>Task of OAuthResponse</returns>
        public async System.Threading.Tasks.Task<OAuthResponse> AuthTokenAsync (string clientId, string clientSecret, string grantType)
        {
             ApiResponse<OAuthResponse> localVarResponse = await AuthTokenAsyncWithHttpInfo(clientId, clientSecret, grantType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate authentication token Generate authentication token
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="grantType"></param>
        /// <returns>Task of ApiResponse (OAuthResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthResponse>> AuthTokenAsyncWithHttpInfo (string clientId, string clientSecret, string grantType)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling AuthenticationApi->AuthToken");
            // verify the required parameter 'clientSecret' is set
            if (clientSecret == null)
                throw new ApiException(400, "Missing required parameter 'clientSecret' when calling AuthenticationApi->AuthToken");
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling AuthenticationApi->AuthToken");

            var localVarPath = "/oauth/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clientId != null) localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (clientSecret != null) localVarFormParams.Add("client_secret", Configuration.ApiClient.ParameterToString(clientSecret)); // form parameter
            if (grantType != null) localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OAuthResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthResponse)));
        }

    }
}
