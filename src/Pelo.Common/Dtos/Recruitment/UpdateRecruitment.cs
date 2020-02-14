using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Recruitment
{
    public class UpdateRecruitment
    {
        [JsonProperty("id")]
        [FromQuery(Name = "id")]
        public int Id { get; set; }

        [JsonProperty("recruitment_status_id")]
        [FromQuery(Name = "recruitment_status_id")]
        public string RecruitmentStatusId { get; set; }

        [JsonProperty("comment")]
        [FromQuery(Name = "comment")]
        public string Comment { get; set; }
    }
}
