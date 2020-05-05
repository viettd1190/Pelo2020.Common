using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Receipt
{
    public class ReceiptUserResponse
    {
        public int Id { get; set; }

        public int ReceiptId { get; set; }

        public int UserId { get; set; }

        public int Type { get; set; }

        public int UserCreated { get; set; }

        public int UserUpdated { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
