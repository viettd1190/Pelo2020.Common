using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;

namespace Pelo.Common.Dtos.Warranty
{
    public class GetWarrantyPagingRequest : GetPagingModel
    {
        [JsonProperty("id")]
        [FromQuery(Name = "id")]
        public int Id{ get; set; }

        [JsonProperty("code")]
        [FromQuery(Name = "code")]
        public string Code { get; set; }

        [JsonProperty("customer_name")]
        [FromQuery(Name = "customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_phone")]
        [FromQuery(Name = "customer_phone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("customer_address")]
        [FromQuery(Name = "customer_address")]
        public string CustomerAddress { get; set; }

        [JsonProperty("branch")]
        [FromQuery(Name = "branch")]
        public string Branch { get; set; }

        [JsonProperty("product")]
        [FromQuery(Name = "product")]
        public string Product{ get; set; }

        [JsonProperty("warrant_status")]
        [FromQuery(Name = "warrant_status")]
        public string WarrantStatus{ get; set; }

        [JsonProperty("warrant_description")]
        [FromQuery(Name = "warrant_description")]
        public string WarrantDescription{ get; set; }

        [JsonProperty("user_created_id")]
        [FromQuery(Name = "user_created_id")]
        public int UserCreatedId { get; set; }

        [JsonProperty("date_created")]
        [FromQuery(Name = "date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("user_care_id")]
        [FromQuery(Name = "user_care_id")]
        public int UserCareId { get; set; }

        [JsonProperty("description")]
        [FromQuery(Name = "description")]
        public string Description { get; set; }

        [JsonProperty("expired_date")]
        [FromQuery(Name = "expired_date")]
        public DateTime ExpiredDate { get; set; }
    }
}
