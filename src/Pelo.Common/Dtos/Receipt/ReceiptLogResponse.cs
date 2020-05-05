using System;
using System.Collections.Generic;

namespace Pelo.Common.Dtos.Receipt
{
    public class ReceiptLogResponse
    {
        public ReceiptLogResponse()
        {
            Attachments = new List<LogAttachment>();
            User = new UserInLog();
            OldReceiptStatus = new StatusInLog();
            ReceiptStatus = new StatusInLog();
        }

        public int Id { get; set; }

        public int CrmId { get; set; }

        public int UserId { get; set; }

        public string Comment { get; set; }

        public DateTime LogDate { get; set; }

        public int OldReceiptStatusId { get; set; }

        public int ReceiptStatusId { get; set; }

        public List<LogAttachment> Attachments { get; set; }

        public UserInLog User { get; set; }

        public StatusInLog OldReceiptStatus { get; set; }

        public StatusInLog ReceiptStatus { get; set; }
    }
}
