using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.ReceiptDescription
{
    public class GetReceiptDescriptionPagingRequest : GetPagingModel
    {
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }
    }
}
