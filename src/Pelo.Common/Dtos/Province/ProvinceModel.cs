using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Province
{
    public class ProvinceModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
