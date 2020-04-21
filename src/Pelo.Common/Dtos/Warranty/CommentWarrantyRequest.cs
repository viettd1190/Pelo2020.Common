using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Warranty
{
    public class CommentWarrantyRequest
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        public int WarrantyStatusId { get; set; }

        public IFormFileCollection Files { get; set; }
    }
}
