using Newtonsoft.Json;

namespace Pelo.Common.Dtos.User
{
    public class GetUserPagingResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }
}