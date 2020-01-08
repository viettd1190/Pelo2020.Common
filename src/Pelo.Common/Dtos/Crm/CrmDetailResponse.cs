using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Crm
{
    public class CrmDetailResponse
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public int CrmStatusId { get; set; }

        public DateTime ContactDate { get; set; }

        public int ProductGroupId { get; set; }

        public int CrmPriorityId { get; set; }

        public int CrmTypeId { get; set; }

        public string Need { get; set; }

        public string Description { get; set; }

        public int CustomerSourceId { get; set; }

        public string Code { get; set; }

        public int Visit { get; set; }

        public int UserCreated { get; set; }

        public DateTime DateCreated { get; set; }

        public int UserUpdated { get; set; }

        public DateTime DateUpdated { get; set; }

    }
}
