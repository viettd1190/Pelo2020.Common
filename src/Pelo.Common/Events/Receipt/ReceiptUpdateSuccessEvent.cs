using System;
using System.Collections.Generic;

namespace Pelo.Common.Events.Receipt
{
    public class ReceiptUpdateSuccessEvent : IEvent
    {
        public ReceiptUpdateSuccessModel BeforeUpdated { get; set; }

        public ReceiptUpdateSuccessModel AfterUpdated { get; set; }

        public int Id { get; set; }

        public string Code { get; set; }

        public int UserId { get; set; }

    }

    public class ReceiptUpdateSuccessModel
    {
        public int ReceiptStatusId { get; set; }

        public List<int> UserCareIds { get; set; }

        public List<int> UserRelativeIds { get; set; }

        public string Description { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}
