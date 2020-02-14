using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Recruitment
{
    public class InsertRecruitment
    {
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("content")]
        [FromQuery(Name = "content")]
        public string Content{ get; set; }

        [JsonProperty("description")] public string Description { get; set; }
    }
}
