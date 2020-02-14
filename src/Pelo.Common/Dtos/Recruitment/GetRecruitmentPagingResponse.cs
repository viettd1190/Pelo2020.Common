using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Recruitment
{
    public class GetRecruitmentPagingResponse
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("color")] public string Color { get; set; }

        [JsonProperty("code")] public string Code { get; set; }

        [JsonProperty("recruitment_status_name")] public string RecruitmentStatusName { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("user_name_created")] public string UserNameCreated { get; set; }

        [JsonProperty("user_phone_created")] public string UserPhoneCreated { get; set; }
    }
}
