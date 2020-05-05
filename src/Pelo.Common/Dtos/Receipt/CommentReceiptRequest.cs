using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Receipt
{
    public class CommentReceiptRequest
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        public int ReceiptStatusId { get; set; }

        public IFormFileCollection Files { get; set; }
    }
}
