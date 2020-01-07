using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Invoice
{
    public class InsertInvoiceRequest
    {
        [JsonProperty("customer_id")]
        public int CustomerId { get; set; }

        [JsonProperty("deposit")]
        public int Deposit { get; set; }

        [JsonProperty("pay_method_id")]
        public int PayMethodId { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("user_sell_id")]
        public int UserSellId { get; set; }

        [JsonProperty("branch_id")]
        public int BranchId { get; set; }

        [JsonProperty("delivery_date")]
        public DateTime DeliveryDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("products")]
        public List<InsertProductInInvoiceRequest> Products { get; set; }
    }
}
