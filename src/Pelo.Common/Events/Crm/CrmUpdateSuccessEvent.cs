using System;
using System.Collections.Generic;

namespace Pelo.Common.Events.Crm
{
    public class CrmUpdateSuccessEvent : IEvent
    {
        public CrmUpdateSuccessModel BeforeUpdated { get; set; }

        public CrmUpdateSuccessModel AfterUpdated { get; set; }

        public int Id { get; set; }

        public string Code { get; set; }

        public int UserId { get; set; }

        public string Reason { get; set; }
    }

    public class CrmUpdateSuccessModel
    {
        public int CrmStatusId { get; set; }

        public int ProductGroupId { get; set; }

        public int CrmPriorityId { get; set; }

        public int CrmTypeId { get; set; }

        public int CustomerSourceId { get; set; }

        public List<int> UserIds { get; set; }

        public string Need { get; set; }

        public string Description { get; set; }

        public int Visit { get; set; }

        public DateTime ContactDate { get; set; }
    }
}
