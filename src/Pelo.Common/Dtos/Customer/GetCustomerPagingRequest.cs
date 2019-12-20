using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;

namespace Pelo.Common.Dtos.Customer
{
    public class GetCustomerPagingRequest : GetPagingModel
    {
        [JsonProperty("code")]
        [FromQuery(Name = "code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("province_id")]
        [FromQuery(Name = "province_id")]
        public int? ProvinceId { get; set; }

        [JsonProperty("district_id")]
        [FromQuery(Name = "district_id")]
        public int? DistrictId { get; set; }

        [JsonProperty("ward_id")]
        [FromQuery(Name = "ward_id")]
        public int? WardId { get; set; }

        [JsonProperty("address")]
        [FromQuery(Name = "address")]
        public string Address { get; set; }

        [JsonProperty("phone")]
        [FromQuery(Name = "phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        [FromQuery(Name = "email")]
        public string Email { get; set; }

        [JsonProperty("customer_group_id")]
        [FromQuery(Name = "customer_group_id")]
        public int CustomerGroupId { get; set; }

        [JsonProperty("customer_vip_id")]
        [FromQuery(Name = "customer_vip_id")]
        public int CustomerVipId { get; set; }
    }
}
