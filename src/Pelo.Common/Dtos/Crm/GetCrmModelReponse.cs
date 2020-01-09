using Newtonsoft.Json;
using Pelo.Common.Dtos.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Crm
{
    public class GetCrmModelReponse
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

        [JsonProperty("customer_address")]
        public string CustomerAddress { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("customer_source_id")]
        public int CustomerSourceId { get; set; }

        [JsonProperty("crm_type_id")]
        public int CrmTypeId { get; set; }

        [JsonProperty("customer_group")]
        public string CustomerGroup { get; set; }

        [JsonProperty("customer_vip")]
        public string CustomerVip{ get; set; }

        [JsonProperty("crm_status_id")]
        public int CrmStatusId { get; set; }

        [JsonProperty("product_group_id")]
        public int ProductGroupId { get; set; }

        [JsonProperty("crm_priority_id")]
        public int CrmPriorityId { get; set; }

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
