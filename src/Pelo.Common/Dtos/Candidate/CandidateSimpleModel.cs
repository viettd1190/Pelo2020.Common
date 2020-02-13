using Newtonsoft.Json;
using System;

namespace Pelo.Common.Dtos.Candidate
{
    public class CandidateSimpleModel
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("color")] public string Color { get; set; }

        [JsonProperty("code")] public string Code { get; set; }

        [JsonProperty("phone")] public string Phone { get; set; }
        
        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("address")] public string Address { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("user_phone_created")] public string UserPhoneCreated { get; set; }

        [JsonProperty("cadidate_status_id")] public string CandidateStatusId { get; set; }

        [JsonProperty("user_name_created")] public string UserNameCreated { get; set; }

        [JsonProperty("date_created")] public DateTime DateCreated { get; set; }
    }
}
