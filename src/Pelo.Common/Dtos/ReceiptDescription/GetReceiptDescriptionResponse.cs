using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.ReceiptDescription
{
    public class GetReceiptDescriptionResponse
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Color")]
        public string Color { get; set; }

        [JsonProperty("IsSendSms")]
        public bool IsSendSms { get; set; }

        [JsonProperty("SmsContent")]
        public string SmsContent { get; set; }

        [JsonProperty("SortOrder")]
        public int SortOrder { get; set; }
    }
}
