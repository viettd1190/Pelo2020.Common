using Newtonsoft.Json;

namespace Pelo.Common.Dtos.ProductGroup
{
    public class ProductGroupSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
