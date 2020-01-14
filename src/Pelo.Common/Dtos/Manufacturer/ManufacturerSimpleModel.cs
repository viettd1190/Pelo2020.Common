using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Manufacturer
{
    public class ManufacturerSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
