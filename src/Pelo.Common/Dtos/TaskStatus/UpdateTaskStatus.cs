using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.TaskStatus
{
    public class UpdateTaskStatus
    {
        [JsonProperty("id")]
        [FromQuery(Name = "id")]
        public int Id { get; set; }

        [JsonProperty("color")]
        [FromQuery(Name = "color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("send_sms")]
        [FromQuery(Name = "send_sms")]
        public bool IsSendSms { get; set; }

        [JsonProperty("sms_content")]
        [FromQuery(Name = "sms_content")]
        public string SmsContent { get; set; }

        [JsonProperty("sort_order")]
        [FromQuery(Name = "sort_order")]
        public int SortOrder { get; set; }
    }
}
