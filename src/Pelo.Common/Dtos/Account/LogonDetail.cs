using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Account
{
    public class LogonDetail
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("username")] public string Username { get; set; }

        [JsonProperty("display_name")] public string DisplayName { get; set; }

        [JsonProperty("avatar")] public string Avatar { get; set; }
    }
}