using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Candidate
{
    public class GetCandidateResponse
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("color")] public string Color { get; set; }

        [JsonProperty("code")] public string Code { get; set; }

        [JsonProperty("phone")] public string Address { get; set; }

        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

    }
}
