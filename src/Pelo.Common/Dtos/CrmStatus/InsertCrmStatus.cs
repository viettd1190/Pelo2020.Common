using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.CrmPriority
{
    public class InsertCrmStatus
    {
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

    }
}
