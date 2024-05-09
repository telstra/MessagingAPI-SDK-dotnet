using Newtonsoft.Json;

namespace com.telstra.messaging.Models.Reports
{
    public class Report
    {
        [JsonProperty("reportId")]
        public string ReportId { get; set; } = string.Empty;

        [JsonProperty("reportStatus")]
        public string? ReportStatus { get; set; }

        [JsonProperty("reportType")]
        public string? ReportType { get; set; }

        [JsonProperty("reportExpiry")]
        public DateTime? ReportExpiry { get; set; }

        [JsonProperty("reportUrl")]
        public string? ReportUrl { get; set; }

        [JsonProperty("reportCallbackUrl")]
        public string? ReportCallbackUrl { get; set; }
    }

    public class ReportsList
    {
        [JsonProperty("reports")]
        public List<Report> Reports { get; set; } = new List<Report>();
    }
}