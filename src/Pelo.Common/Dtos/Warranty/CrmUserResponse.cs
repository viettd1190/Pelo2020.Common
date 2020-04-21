using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Warranty
{
    public class WarrantyUserResponse
    {
        public int Id { get; set; }

        public int WarrantyId { get; set; }

        public int UserId { get; set; }

        public int Type { get; set; }

        public int UserCreated { get; set; }

        public int UserUpdated { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
