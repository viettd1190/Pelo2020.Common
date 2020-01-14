using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Manufacturer
{
    public class InsertManufacturerRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
