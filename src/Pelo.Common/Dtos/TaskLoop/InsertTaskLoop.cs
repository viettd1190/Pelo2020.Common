using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.TaskLoop
{
    public class InsertTaskLoop
    {
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("sort_order")]
        [FromQuery(Name = "sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("day_count")]
        [FromQuery(Name = "day_count")]
        public int DayCount { get; set; }
    }
}
