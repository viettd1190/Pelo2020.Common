using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Warranty
{
    public class GetWarrantyPagingResponse
    {
        public int Id { get; set; }

        public string Customer { get; set; }

        public string Code { get; set; }

        public string UserCreated { get; set; }

        public string UserUpdated { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public string WarrantStatus { get; set; }

        public string WarrantStatusColor { get; set; }
    }
}
