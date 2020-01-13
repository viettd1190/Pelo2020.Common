using Newtonsoft.Json;

namespace Pelo.Common.Dtos.WarrantyStatus
{
    public class WarrantyStatusSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
