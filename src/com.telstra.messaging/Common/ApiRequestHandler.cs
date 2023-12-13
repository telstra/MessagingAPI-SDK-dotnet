namespace com.telstra.messaging.Common
{
    public class ApiRequestHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Intercept the request here before it is sent
            Console.WriteLine($"Request intercepted: {request.Method} {request.RequestUri}");

            // You can modify the request, add headers, etc.
            // For example, adding an Authorization header
            // request.Headers.Add("Authorization", "Bearer YOUR_ACCESS_TOKEN");

            // Continue with the request by calling the base SendAsync method
            var response = await base.SendAsync(request, cancellationToken);

            return response;
        }
    }
}