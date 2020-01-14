using Newtonsoft.Json;

namespace Pelo.Common.Dtos.ProductUnit
{
    public class ProductStatusSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
