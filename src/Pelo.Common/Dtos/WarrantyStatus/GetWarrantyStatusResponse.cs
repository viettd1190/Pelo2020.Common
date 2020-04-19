using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.WarrantyStatus
{
    public class GetWarrantyStatusResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("color")]
        [FromQuery(Name = "color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("sort_order")]
        [FromQuery(Name = "sort_order")]
        public int SortOrder { get; set; }

    }
}
