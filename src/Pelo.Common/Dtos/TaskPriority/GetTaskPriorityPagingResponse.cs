﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.TaskPriority
{
    public class GetTaskPriorityPagingResponse
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name{ get; set; }

        [JsonProperty("color")] public string Color { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }
    }
}
