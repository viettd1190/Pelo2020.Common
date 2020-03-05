using System;
using System.Collections.Generic;

namespace Pelo.Common.Dtos.Crm
{
    public class CrmLogResponse
    {
        public CrmLogResponse()
        {
            Attachments = new List<CrmLogAttachment>();
            User = new UserInLog();
            OldCrmStatus = new CrmStatusInLog();
            CrmStatus = new CrmStatusInLog();
        }

        public int Id { get; set; }

        public int CrmId { get; set; }

        public int UserId { get; set; }

        public string Comment { get; set; }

        public DateTime LogDate { get; set; }

        public int OldCrmStatusId { get; set; }

        public int CrmStatusId { get; set; }

        public List<CrmLogAttachment> Attachments { get; set; }

        public UserInLog User { get; set; }

        public CrmStatusInLog OldCrmStatus { get; set; }

        public CrmStatusInLog CrmStatus { get; set; }
    }

    public class CrmLogAttachment
    {
        public string Attachment { get; set; }

        public string AttachmentName { get; set; }
    }

    public class UserInLog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Avatar { get; set; }
    }

    public class CrmStatusInLog
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
