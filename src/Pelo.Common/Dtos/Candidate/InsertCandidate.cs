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

        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("phone")] public string Phone { get; set; }

        [JsonProperty("candidateStatusId")]
        public int CandidateStatusId { get; set; }

        [JsonProperty("address")] public string Address { get; set; }
    }
}
