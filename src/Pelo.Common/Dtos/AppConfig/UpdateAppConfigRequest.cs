using Newtonsoft.Json;

namespace Pelo.Common.Dtos.AppConfig
{
    public class UpdateAppConfigRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
