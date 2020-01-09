using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;

namespace Pelo.Common.Dtos.Crm
{
    public class GetWarrantyPagingRequest : GetPagingModel
    {
        [JsonProperty("code")]
        [FromQuery(Name = "code")]
        public string Code { get; set; }

        [JsonProperty("customer_code")]
        [FromQuery(Name = "customer_code")]
        public string CustomerCode { get; set; }

        [JsonProperty("customer_name")]
        [FromQuery(Name = "customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_phone")]
        [FromQuery(Name = "customer_phone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("customer_address")]
        [FromQuery(Name = "customer_address")]
        public string CustomerAddress { get; set; }

        [JsonProperty("province_id")]
        [FromQuery(Name = "province_id")]
        public int ProvinceId { get; set; }

        [JsonProperty("district_id")]
        [FromQuery(Name = "district_id")]
        public int DistrictId { get; set; }

        [JsonProperty("ward_id")]
        [FromQuery(Name = "ward_id")]
        public int WardId { get; set; }

        [JsonProperty("customer_group_id")]
        [FromQuery(Name = "customer_group_id")]
        public int CustomerGroupId { get; set; }

        [JsonProperty("customer_vip_id")]
        [FromQuery(Name = "customer_vip_id")]
        public int CustomerVipId { get; set; }

        [JsonProperty("customer_source_id")]
        [FromQuery(Name = "customer_source_id")]
        public int CustomerSourceId { get; set; }

        [JsonProperty("product_group_id")]
        [FromQuery(Name = "product_group_id")]
        public int ProductGroupId { get; set; }

        [JsonProperty("crm_status_id")]
        [FromQuery(Name = "crm_status_id")]
        public int CrmStatusId { get; set; }

        [JsonProperty("crm_type_id")]
        [FromQuery(Name = "crm_type_id")]
        public int CrmTypeId { get; set; }

        [JsonProperty("crm_priority_id")]
        [FromQuery(Name = "crm_priority_id")]
        public int CrmPriorityId { get; set; }

        [JsonProperty("visit")]
        [FromQuery(Name = "visit")]
        public int Visit { get; set; }

        [JsonProperty("from_date")]
        [FromQuery(Name = "from_date")]
        public DateTime? FromDate { get; set; }

        [JsonProperty("to_date")]
        [FromQuery(Name = "to_date")]
        public DateTime? ToDate { get; set; }

        [JsonProperty("user_created_id")]
        [FromQuery(Name = "user_created_id")]
        public int UserCreatedId { get; set; }

        [JsonProperty("date_created")]
        [FromQuery(Name = "date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("user_care_id")]
        [FromQuery(Name = "user_care_id")]
        public int UserCareId { get; set; }

        [JsonProperty("need")]
        [FromQuery(Name = "need")]
        public string Need { get; set; }
    }
}
