using System.ComponentModel.DataAnnotations;
using com.telstra.messaging.Utils;
using Newtonsoft.Json;

namespace com.telstra.messaging.Models.FreeTrialNumbers
{
    public class FreeTrialNumbersList
    {
        private List<string>? _freeTrialNumbers;

        [JsonProperty("freeTrialNumbers")]
        public List<string> FreeTrialNumbers
        {
            get
            {
                return _freeTrialNumbers ?? new List<string>();
            }
            set
            {
                if (value.Count < 1 || value.Count > 10)
                {
                    throw new ValidationException("FreeTrialNumbers value out of range. Expected atleast on number or maximum of 10 numbers.");
                }

                if (value.Any(N => N.Length != 10 || !Helper.IsStringDigitsOnly(N)))
                {
                    throw new ValidationException("One or more numbers in the list are not valid Australian mobile number or not in the format '04xxxxxxxx'");
                }

                _freeTrialNumbers = value;
            }
        }

        public FreeTrialNumbersList(List<string> freeTrialNumbers)
        {
            FreeTrialNumbers = freeTrialNumbers;
        }
    }
}