
using System.ComponentModel.DataAnnotations;
using com.telstra.messaging.Utils;
using Newtonsoft.Json;

namespace com.telstra.messaging.Models.Reports
{
    public class CreateReportsParams
    {
        private DateTime _startDate;

        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                if (value > DateTime.Now || value < DateTime.Now.AddDays(-90))
                {
                    throw new ValidationException("Invalid value. StartDate should be in past and not older than 90 days.");
                }

                _startDate = value;
            }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get { return _endDate; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ValidationException("Invalid value. EndDate should be in past and not older than 90 days from StartDate.");
                }

                _endDate = value;
            }
        }

        public string? ReportCallbackUrl { get; set; }

        public string? Filter { get; set; }

        public CreateReportsParams(DateTime startDate, DateTime endDate, string? reportCallbackUrl = null, string? filter = null)
        {
            StartDate = startDate;
            EndDate = endDate;
            ValidateDates(startDate, endDate);
            ReportCallbackUrl = reportCallbackUrl;
            Filter = filter;
        }

        private void ValidateDates(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new ValidationException("Report StartDate should be older than EndDate.");
            }
        }
    }
}