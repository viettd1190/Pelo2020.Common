using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Crm
{
    public class CrmUserResponse
    {
        public int Id { get; set; }

        public int CrmId { get; set; }

        public int UserId { get; set; }

        public int Type { get; set; }

        public int UserCreated { get; set; }

        public int UserUpdated { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

    }
}
