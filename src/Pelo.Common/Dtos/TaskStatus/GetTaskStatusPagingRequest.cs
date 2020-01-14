using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.TaskStatus
{
    public class GetTaskStatusPagingRequest : GetPagingModel
    {
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }
    }
}
