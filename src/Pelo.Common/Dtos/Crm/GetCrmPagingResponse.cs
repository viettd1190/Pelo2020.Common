using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Pelo.Common.Dtos.User;

namespace Pelo.Common.Dtos.Crm
{
    public class GetCrmPagingResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("crm_status")]
        public string CrmStatus { get; set; }

        [JsonProperty("crm_status_color")]
        public string CrmStatusColor { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_phone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("customer_phone_2")]
        public string CustomerPhone2 { get; set; }

        [JsonProperty("customer_phone_3")]
        public string CustomerPhone3 { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("ward")]
        public string Ward { get; set; }

        [JsonProperty("customer_address")]
        public string CustomerAddress { get; set; }

        [JsonProperty("customer_group")]
        public string CustomerGroup { get; set; }

        [JsonProperty("customer_vip")]
        public string CustomerVip { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("product_group")]
        public string ProductGroup { get; set; }

        [JsonProperty("crm_priority")]
        public string CrmPriority { get; set; }

        [JsonProperty("customer_source")]
        public string CustomerSource { get; set; }

        [JsonProperty("crm_type")]
        public string CrmType { get; set; }

        [JsonProperty("visit")]
        public int Visit { get; set; }

        [JsonProperty("user_created")]
        public string UserCreated { get; set; }

        [JsonProperty("user_created_phone")]
        public string UserCreatedPhone { get; set; }

        [JsonProperty("contact_date")]
        public DateTime ContactDate { get; set; }

        [JsonProperty("date_created")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("user_cares")]
        public List<UserDisplaySimpleModel> UserCares { get; set; } = new List<UserDisplaySimpleModel>();

        [JsonProperty("customer_id")]
        public int CustomerId { get; set; }
    }
}
