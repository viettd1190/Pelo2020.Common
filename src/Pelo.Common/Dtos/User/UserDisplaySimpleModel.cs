using Newtonsoft.Json;
using NLog.Layouts;

namespace Pelo.Common.Dtos.User
{
    public class UserDisplaySimpleModel
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
