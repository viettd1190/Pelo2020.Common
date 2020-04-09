using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Candidate
{
    public class GetCandidatePagingRequest : GetPagingModel
    {
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        [FromQuery(Name = "phone")]
        public string Phone { get; set; }

        [JsonProperty("code")]
        [FromQuery(Name = "code")]
        public string Code { get; set; }

        [JsonProperty("candidate_statusId")]
        [FromQuery(Name = "candidate_statusId")]
        public int CandidateStatusId { get; set; } = 0;

        [JsonProperty("from_date")]
        [FromQuery(Name = "from_date")]
        public string FromDate { get; set; } = null;

        [JsonProperty("to_date")]
        [FromQuery(Name = "to_date")]
        public string ToDate { get; set; } = null;
    }
}
