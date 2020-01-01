using System;
using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Customer
{
    public class GetCustomerDetailResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("birth_date")]
        public DateTime BirthDate { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phone_2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone_3")]
        public string Phone3 { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("province_type")]
        public string ProvinceType { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("district_type")]
        public string DistrictType { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("ward_type")]
        public string WardType { get; set; }

        [JsonProperty("ward")]
        public string Ward { get; set; }

        [JsonProperty("customer_group")]
        public string CustomerGroup { get; set; }

        [JsonProperty("customer_vip")]
        public string CustomerVip { get; set; }

        [JsonProperty("profit")]
        public int Profit { get; set; }

        [JsonProperty("profit_update")]
        public int ProfitUpdate { get; set; }

        [JsonProperty("user_care")]
        public string UserCare { get; set; }

        [JsonProperty("user_care_phone")]
        public string UserCarePhone { get; set; }

        [JsonProperty("user_first")]
        public string UserFirst { get; set; }

        [JsonProperty("user_first_phone")]
        public string UserFirstPhone { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("user_created")]
        public string UserCreated { get; set; }

        [JsonProperty("user_created_phone")]
        public string UserCreatedPhone { get; set; }

        [JsonProperty("date_created")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("date_updated")]
        public DateTime DateUpdated { get; set; }
    }
}
