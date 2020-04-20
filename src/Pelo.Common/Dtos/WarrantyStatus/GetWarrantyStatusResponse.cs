using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.WarrantyStatus
{
    public class GetWarrantyStatusResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }


        [JsonProperty("is_send_sms")]
        public bool IsSendSms { get; set; }

        [JsonProperty("sms_content")]
        public string SmsContent { get; set; }

    }
}
