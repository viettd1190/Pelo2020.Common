using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Crm
{
    public class CommentCrmRequest
    {
        public int Id { get; set; }

        public int CrmStatusId { get; set; }

        public string Comment { get; set; }

        public IFormFile File { get; set; }
    }
}
