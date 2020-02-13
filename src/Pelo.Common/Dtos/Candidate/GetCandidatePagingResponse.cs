using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Candidate
{
    public class GetCandidatePagingResponse
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name{ get; set; }

        [JsonProperty("color")] public string Color { get; set; }

        [JsonProperty("code")] public string Code { get; set; }

        [JsonProperty("candidate_status_name")] public string CandidateStatusName { get; set; }

        [JsonProperty("phone")]
        public string Phone{ get; set; }

        [JsonProperty("description")] public string Description{ get; set; }

        [JsonProperty("user_name_created")] public string UserNameCreated { get; set; }

        [JsonProperty("user_phone_created")] public string UserPhoneCreated { get; set; }
    }
}
