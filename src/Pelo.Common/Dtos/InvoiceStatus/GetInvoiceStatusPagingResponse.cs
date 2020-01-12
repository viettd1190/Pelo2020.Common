﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.InvoiceStatus
{
    public class GetInvoiceStatusPagingResponse
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name{ get; set; }

        [JsonProperty("color")] public string Color { get; set; }


        [JsonProperty("send_sms")] public string IsSendSms { get; set; }

        [JsonProperty("sms_content")] public string SmsContent { get; set; }
    }
}
