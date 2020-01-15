using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Product
{
    public class InsertProduct
    {

        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("import_price")]
        [FromQuery(Name = "import_price")]
        public int ImportPrice { get; set; }

        [JsonProperty("sell_price")]
        [FromQuery(Name = "sell_price")]
        public int SellPrice { get; set; }

        [JsonProperty("min_count")]
        [FromQuery(Name = "min_count")]
        public int MinCount { get; set; }

        [JsonProperty("max_count")]
        [FromQuery(Name = "max_count")]
        public int MaxCount { get; set; }

        [JsonProperty("warrant_month")]
        [FromQuery(Name = "warrant_month")]
        public int WarrantyMonth { get; set; }

        [JsonProperty("product_status_id")]
        [FromQuery(Name = "product_status_id")]
        public int ProductStatusId { get; set; }

        [JsonProperty("product_group_id")]
        [FromQuery(Name = "product_group_id")]
        public int ProductGroupId { get; set; }

        [JsonProperty("product_unit_id")]
        [FromQuery(Name = "product_unit_id")]
        public int ProductUnitId { get; set; }

        [JsonProperty("manufacturer_id")]
        [FromQuery(Name = "manufacturer_id")]
        public int ManufacturerId { get; set; }

        [JsonProperty("country_id")]
        [FromQuery(Name = "country_id")]
        public int CountryId { get; set; }

        [JsonProperty("description")]
        [FromQuery(Name = "description")]
        public string Description { get; set; }

    }
}
