using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Candidate
{
    public class InsertCandidate
    {
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("color")] public string Color { get; set; }

        [JsonProperty("code")] public string Code { get; set; }

        [JsonProperty("phone")] public string Address { get; set; }

        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("description")] public string Description { get; set; }
    }
}
