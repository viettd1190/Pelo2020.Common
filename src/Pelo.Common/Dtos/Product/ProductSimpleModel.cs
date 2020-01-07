using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Product
{
    public class ProductSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("import_price")]
        public int ImportPrice { get; set; }

        [JsonProperty("sell_price")]
        public int SellPrice { get; set; }
    }
}
