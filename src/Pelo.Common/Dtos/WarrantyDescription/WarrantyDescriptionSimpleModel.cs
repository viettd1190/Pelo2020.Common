using Newtonsoft.Json;

namespace Pelo.Common.Dtos.WarrantyDescription
{
    public class WarrantyDescriptionSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}