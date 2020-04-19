using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Warranty
{
    public class GetWarrantyPagingResponse
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string CustomerPhone1 { get; set; }
        public string CustomerPhone2 { get; set; }
        public string CustomerPhone3 { get; set; }

        public string Code { get; set; }

        public string UserCreated { get; set; }

        public string UserCreatedPhone { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DateTime DateCreated { get; set; }

        public string CustomerAddress { get; set; }

        public string WarrantyStatus { get; set; }

        public string WarrantyStatusColor { get; set; }

        public string Branch { get; set; }

        public List<ProductInWarrantySimple> Products { get; set; } = new List<ProductInWarrantySimple>();

    }
}
