namespace com.telstra.messaging.Utils
{
    public static class Helper
    {
        public static bool IsStringDigitsOnly(string stringValue)
        {
            foreach (var c in stringValue)
            {
                if (c is < '0' or > '9')
                    return false;
            }
            return true;
        }

        public static bool IsValidUUID(string uuid)
        {
            return Guid.TryParse(uuid, out _);
        }
    }
}