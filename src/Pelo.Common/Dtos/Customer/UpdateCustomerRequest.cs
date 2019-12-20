using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Customer
{
    public class UpdateCustomerRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }

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

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
