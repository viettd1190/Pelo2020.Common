using Newtonsoft.Json;

namespace Pelo.Common.Dtos.District
{
    public class DistrictModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("province_id")]
        public int ProvinceId { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }
    }
}
