using System;
using System.Collections.Generic;

namespace Pelo.Common.Events.Warranty
{
    public class WarrantyUpdateSuccessEvent : IEvent
    {
        public WarrantyUpdateSuccessModel BeforeUpdated { get; set; }

        public WarrantyUpdateSuccessModel AfterUpdated { get; set; }

        public int Id { get; set; }

        public string Code { get; set; }

        public int UserId { get; set; }

    }

    public class WarrantyUpdateSuccessModel
    {
        public int WarrantyStatusId { get; set; }

        public List<int> UserCareIds { get; set; }

        public List<int> UserRelativeIds { get; set; }

        public string Description { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}
