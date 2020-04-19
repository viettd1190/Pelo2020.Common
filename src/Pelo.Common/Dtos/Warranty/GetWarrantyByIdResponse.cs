using Newtonsoft.Json;
using Pelo.Common.Dtos.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Warranty
{
    public class GetWarrantyByIdResponse
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("warranty_status")] public string WarrantyStatus { get; set; }

        [JsonProperty("warranty_status_color")] public string WarrantyStatusColor { get; set; }

        [JsonProperty("code")] public string Code { get; set; }

        [JsonProperty("customer")] public string CustomerName { get; set; }

        [JsonProperty("customer_id")] public int CustomerId { get; set; }

        [JsonProperty("deposit")]
        public int Deposit { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("warranty_status_id")]
        public int WarrantyStatusId { get; set; }

        [JsonProperty("customer_phone_1")] public string CustomerPhone1 { get; set; }

        [JsonProperty("customer_phone_2")] public string CustomerPhone2 { get; set; }

        [JsonProperty("customer_phone_3")] public string CustomerPhone3 { get; set; }

        [JsonProperty("customer_address")] public string CustomerAddress { get; set; }

        [JsonProperty("customer_code")] public string CustomerCode { get; set; }

        [JsonProperty("branch")] public string Branch { get; set; }

        [JsonProperty("user_created")] public string UserCreated { get; set; }

        [JsonProperty("user_created_phone")] public string UserCreatedPhone { get; set; }

        [JsonProperty("delivery_date")] public DateTime DeliveryDate { get; set; }

        [JsonProperty("date_created")] public DateTime DateCreated { get; set; }

        [JsonProperty("products")] public List<ProductInWarranty> Products { get; set; } = new List<ProductInWarranty>();

        [JsonProperty("users_care")] public List<UserDisplaySimpleModel> UsersCare { get; set; } = new List<UserDisplaySimpleModel>();

        [JsonProperty("users_incharge")] public List<UserDisplaySimpleModel> UsersInCharge { get; set; } = new List<UserDisplaySimpleModel>();
    }
}
