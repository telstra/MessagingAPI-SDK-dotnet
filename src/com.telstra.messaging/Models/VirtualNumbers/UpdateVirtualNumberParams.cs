using System.ComponentModel.DataAnnotations;
using com.telstra.messaging.Utils;

namespace com.telstra.messaging.Models.VirtualNumbers
{
    public class UpdateVirtualNumberParams
    {
        private string? _number;
        public string Number
        {
            get
            {
                return _number ?? string.Empty;
            }

            set
            {
                if (value.Length != 10 || !Helper.IsStringDigitsOnly(value))
                {
                    throw new ValidationException("Number is not a valid virtual number.");
                }

                _number = value;
            }
        }

        public AssignVirtualNumberParams UpdateData { get; set; }

        public UpdateVirtualNumberParams(string number, AssignVirtualNumberParams assignVirtualNumberParams)
        {
            Number = number;
            UpdateData = assignVirtualNumberParams;
        }
    }
}