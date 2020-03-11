using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Pelo.Common.Dtos.Crm
{
    public class CommentCrmRequest
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        public IFormFileCollection Files { get; set; }
    }
}
