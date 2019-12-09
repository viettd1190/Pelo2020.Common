using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Account
{
    public class LogonResponse
    {
        public LogonResponse(string accessToken)
        {
            AccessToken = accessToken;
        }

        [JsonProperty("access_token")] 
        public string AccessToken { get; private set; }
    }
}