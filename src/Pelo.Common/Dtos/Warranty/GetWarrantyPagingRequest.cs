using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;

namespace Pelo.Common.Dtos.Warranty
{
    public class GetWarrantyPagingRequest : GetPagingModel
    {
        [JsonProperty("code")]
        [FromQuery(Name = "code")]
        public string Code { get; set; }

        [JsonProperty("customer_name")]
        [FromQuery(Name = "customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_phone")]
        [FromQuery(Name = "customer_phone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("warranty_status_id")]
        [FromQuery(Name = "warranty_status_id")]
        public int WarrantyStatusId{ get; set; }

        [JsonProperty("user_created_id")]
        [FromQuery(Name = "user_created_id")]
        public int UserCreatedId { get; set; }

        [JsonProperty("from_date")]
        [FromQuery(Name = "from_date")]
        public string FromDate { get; set; } = null;

        [JsonProperty("to_date")]
        [FromQuery(Name = "to_date")]
        public string ToDate { get; set; } = null;
        [JsonProperty("user_care_id")]
        [FromQuery(Name = "user_care_id")]
        public int UserCareId { get; set; }

    }
}
