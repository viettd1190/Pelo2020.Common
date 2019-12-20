using System;
using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Customer
{
    public class GetCustomerPagingResponse
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

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("ward")]
        public string Ward { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("customer_group")]
        public string CustomerGroup { get; set; }

        [JsonProperty("customer_vip")]
        public string CustomerVip { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("date_updated")]
        public DateTime DateUpdated { get; set; }
    }
}
