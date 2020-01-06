using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;

namespace Pelo.Common.Dtos.Invoice
{
    public class GetInvoicePagingRequest : GetPagingModel
    {
        [JsonProperty("customer_name")]
        [FromQuery(Name = "customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_code")]
        [FromQuery(Name = "customer_code")]
        public string CustomerCode { get; set; }

        [JsonProperty("customer_phone")]
        [FromQuery(Name = "customer_phone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("code")]
        [FromQuery(Name = "code")]
        public string Code { get; set; }

        [JsonProperty("branch_id")]
        [FromQuery(Name = "branch_id")]
        public int BranchId { get; set; }

        [JsonProperty("invoice_status_id")]
        [FromQuery(Name = "invoice_status_id")]
        public int InvoiceStatusId { get; set; }

        [JsonProperty("user_created_id")]
        [FromQuery(Name = "user_created_id")]
        public int UserCreatedId { get; set; }

        [JsonProperty("user_sell_id")]
        [FromQuery(Name = "user_sell_id")]
        public int UserSellId { get; set; }

        [JsonProperty("user_delivery_id")]
        [FromQuery(Name = "user_delivery_id")]
        public int UserDeliveryId { get; set; }

        [JsonProperty("from_date")]
        [FromQuery(Name = "from_date")]
        public DateTime? FromDate { get; set; }

        [JsonProperty("to_date")]
        [FromQuery(Name = "to_date")]
        public DateTime? ToDate { get; set; }
    }
}
