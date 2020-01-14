using Newtonsoft.Json;

namespace Pelo.Common.Dtos.District
{
    public class BranchModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("hotline")]
        public string Hotline { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("province_id")]
        public int ProvinceId { get; set; }

        [JsonProperty("district_id")]
        public int DistrictId { get; set; }

        [JsonProperty("ward_id")]
        public int WardId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
