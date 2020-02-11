using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Province
{
    public class ProvinceModel
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("SortOrder")]
        public int SortOrder { get; set; }
    }
}
