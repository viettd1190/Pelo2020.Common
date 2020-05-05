using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Events.Receipt
{
    public class ReceiptCommentSuccessEvent : IEvent
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public int ReceiptStatusId { get; set; }

        public int UserId { get; set; }

        public string Comment { get; set; }

        public bool HasAttachmentFile { get; set; }
    }
}
