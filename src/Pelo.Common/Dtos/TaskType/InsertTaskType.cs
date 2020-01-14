using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.TaskType
{
    public class InsertTaskType
    {
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("sort_order")]
        [FromQuery(Name = "sort_order")]
        public int SortOrder { get; set; }
    }
}
