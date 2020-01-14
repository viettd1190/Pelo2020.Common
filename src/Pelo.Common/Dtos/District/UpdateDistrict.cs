using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.District
{
    public class UpdateDistrict
    {
        [JsonProperty("id")]
        [FromQuery(Name = "id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        [FromQuery(Name = "type")]
        public string Type { get; set; }

        [JsonProperty("province_id")]
        [FromQuery(Name = "province_id")]
        public int ProvinceId{ get; set; }

        [JsonProperty("sort_order")]
        [FromQuery(Name = "sort_order")]
        public int SortOrder { get; set; }
    }
}
