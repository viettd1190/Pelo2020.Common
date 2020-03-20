using System;
using System.Collections.Generic;
using Pelo.Common.Dtos.User;

namespace Pelo.Common.Dtos.Invoice
{
    public class GetInvoiceByIdResponse
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string UserCreated { get; set; }

        public string UserCreatedPhone { get; set; }

        public DateTime DateCreated { get; set; }

        public int CustomerId { get; set; }

        public string UserSell { get; set; }

        public string UserSellPhone { get; set; }

        public DateTime DeliveryDate { get; set; }

        public int DeliveryCost { get; set; }

        public int Discount { get; set; }

        public int Deposit { get; set; }

        public string PayMethod { get; set; }

        public string Description { get; set; }

        public int InvoiceStatusId { get; set; }

        public List<ProductInInvoice> Products { get; set; }

        public List<UserDisplaySimpleModel> UserCares { get; set; }

        public List<UserDisplaySimpleModel> UserDeliveries { get; set; }
    }

    public class ProductInInvoice
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ImportPrice { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }
    }
}
