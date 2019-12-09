using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Account
{
    public class LogonRequest
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}