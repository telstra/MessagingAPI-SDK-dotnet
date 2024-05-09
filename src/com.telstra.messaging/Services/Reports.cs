using com.telstra.messaging.Common;
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.Reports;
using Newtonsoft.Json;

namespace com.telstra.messaging
{
    public class Reports : Client
    {
        public Reports(Credentials? credentials = null) : base(credentials ?? new Credentials())
        {

        }

        public async Task<Report> Create(CreateReportsParams createReportsParams)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Post, "/messaging/v3/reports/messages", createReportsParams);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<Report>(responseContent);
                    return responseObject ?? new Report();
                }
                else
                {
                    throw new Exception($"Failed to create Messages Report. {responseContent}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to create Messages Report. {ex.Message}");
            }
        }

        public async Task<Report> CreateDailySummary(CreateReportsParams createReportsParams)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Post, "/messaging/v3/reports/messages/daily", createReportsParams);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<Report>(responseContent);
                    return responseObject ?? new Report();
                }
                else
                {
                    throw new Exception($"Failed to create Messages Daily Summary Report. {responseContent}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to create Messages Daily Summary Report. {ex.Message}");
            }
        }

        public async Task<ReportsList> GetAll()
        {
            try
            {
                var response = await SendAsync(HttpMethod.Get, "/messaging/v3/reports");
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<ReportsList>(responseContent);
                    return responseObject ?? new ReportsList();
                }
                else
                {
                    throw new Exception($"Failed to get Reports. {responseContent}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get Reports. {ex.Message}");
            }
        }

        public async Task<Report> Get(string reportId)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Get, $"/messaging/v3/reports/{reportId}");
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<Report>(responseContent);
                    return responseObject ?? new Report();
                }
                else
                {
                    throw new Exception($"Failed to get the Report. {responseContent}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get the Report. {ex.Message}");
            }
        }
    }
}
