using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Warranty
{
    public class InsertWarrantyRequest
    {
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

        [JsonProperty("products")]
        public List<InsertProductInWarrantyRequest> Products { get; set; }
    }
}
