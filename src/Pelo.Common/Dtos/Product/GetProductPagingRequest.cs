using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Product
{
    public class GetProductPagingRequest : GetPagingModel
    {
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

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

        [JsonProperty("warranty_month")]
        [FromQuery(Name = "warranty_month")]
        public int WarrantyMonth { get; set; }
    }
}
