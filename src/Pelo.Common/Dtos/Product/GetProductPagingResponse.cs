using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Product
{
    public class GetProductPagingResponse
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name{ get; set; }

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

        [JsonProperty("product_status")]
        public string ProductStatus { get; set; }

        [JsonProperty("product_group")]
        public string ProductGroup { get; set; }

        [JsonProperty("product_unit")]
        public string ProductUnit { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("user_updated")]
        public string UserUpdated { get; set; }

        [JsonProperty("date_updated")]
        public DateTime DateUpdated { get; set; }
    }
}
