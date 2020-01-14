using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.ReceiptStatus
{
    public class GetReceiptStatusPagingRequest : GetPagingModel
    {
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }
    }
}
