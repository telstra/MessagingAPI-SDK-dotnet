namespace com.telstra.messaging.Models.Common
{
    public class AuthToken
    {
        private string _accessToken = string.Empty;
        private int _expiresIn = 0;
        private DateTime _acquiredAt;
        private DateTime _expiresAt;
        private string _tokenType = string.Empty;

        public string AccessToken { get { return _accessToken; } }
        public bool IsExpired { get { return _expiresAt.AddSeconds(-30) <= DateTime.Now; } }

        public AuthToken(string accessToken, string tokenType, int expiresIn)
        {
            _accessToken = accessToken;
            _tokenType = tokenType;
            _expiresIn = expiresIn;
            _acquiredAt = DateTime.Now;
            _expiresAt = _acquiredAt.AddSeconds(_expiresIn);
        }
    }
}
