using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Department
{
    public class GetDepartmentPagingRequest : GetPagingModel
    {
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }
    }
}
