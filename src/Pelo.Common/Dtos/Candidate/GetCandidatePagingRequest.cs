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
        public string CandidateStatusId { get; set; }
        
        [JsonProperty("from_date")]
        [FromQuery(Name = "from_date")]
        public DateTime FromDate { get; set; }
        
        [JsonProperty("to_date")]
        [FromQuery(Name = "to_date")]
        public DateTime ToDate { get; set; }
    }
}
