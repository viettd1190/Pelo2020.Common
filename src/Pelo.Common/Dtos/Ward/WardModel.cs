using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Ward
{
    public class WardModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("district_id")]
        public int DistrictId { get; set; }
    }
}
