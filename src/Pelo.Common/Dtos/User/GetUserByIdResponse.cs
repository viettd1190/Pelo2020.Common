using Newtonsoft.Json;

namespace Pelo.Common.Dtos.User
{
    public class GetUserByIdResponse : UpdateUserRequest
    {
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
