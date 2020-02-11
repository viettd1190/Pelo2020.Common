using Newtonsoft.Json;

namespace Pelo.Common.Dtos.ProductStatus
{
    public class ProductStatusSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
