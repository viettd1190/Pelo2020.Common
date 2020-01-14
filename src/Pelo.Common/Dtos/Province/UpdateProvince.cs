using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Province
{
    public class UpdateProvince
    {
        [JsonProperty("id")]
        [FromQuery(Name = "id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("sort_order")]
        [FromQuery(Name = "sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("type")]
        [FromQuery(Name = "type")]
        public string Type { get; set; }
    }
}
