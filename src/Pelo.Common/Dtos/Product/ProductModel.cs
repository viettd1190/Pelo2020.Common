using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Product
{
    public class ProductModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name{ get; set; }

        [JsonProperty("import_price")]
        public int ImportPrice { get; set; }

        [JsonProperty("sell_price")]
        public int SellPrice { get; set; }

        [JsonProperty("min_count")]
        public int MinCount { get; set; }

        [JsonProperty("max_count")]
        public int MaxCount { get; set; }

        [JsonProperty("warrant_month")]
        public int WarrantyMonth { get; set; }

        [JsonProperty("product_status_id")]
        public int ProductStatusId { get; set; }

        [JsonProperty("product_group_id")]
        public int ProductGroupId { get; set; }

        [JsonProperty("product_unit_id")]
        public int ProductUnitId { get; set; }

        [JsonProperty("manufacturer_id")]
        public int Manufacturer { get; set; }

        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
