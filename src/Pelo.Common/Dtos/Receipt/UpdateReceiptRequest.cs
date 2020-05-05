using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Receipt
{
    public class UpdateReceiptRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("customer_id")]
        public int CustomerId { get; set; }

        [JsonProperty("deposit")]
        public int Deposit { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("branch_id")]
        public int BranchId { get; set; }

        [JsonProperty("delivery_date")]
        public DateTime DeliveryDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("user_relative_ids")]
        public List<int> UserRelativeIds { get; set; }

        [JsonProperty("user_care_ids")]
        public List<int> UserCareIds { get; set; }

        [JsonProperty("products")]
        public List<ProductInReceiptRequest> Products { get; set; }
    }
}
