using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Customer
{
    public class GetCustomerByIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phone_2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone_3")]
        public string Phone3 { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("province_id")]
        public int ProvinceId { get; set; }

        [JsonProperty("district_id")]
        public int DistrictId { get; set; }

        [JsonProperty("ward_id")]
        public int WardId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("customer_group_id")]
        public int CustomerGroupId { get; set; }

        [JsonProperty("customer_vip")]
        public string CustomerVip { get; set; }

        [JsonProperty("profit")]
        public int Profit { get; set; }

        [JsonProperty("profit_update")]
        public int ProfitUpdate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
