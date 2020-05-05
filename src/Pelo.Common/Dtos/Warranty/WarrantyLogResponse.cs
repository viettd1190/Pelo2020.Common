﻿using System;
using System.Collections.Generic;

namespace Pelo.Common.Dtos.Warranty
{
    public class WarrantyLogResponse
    {
        public WarrantyLogResponse()
        {
            Attachments = new List<LogAttachment>();
            User = new UserInLog();
            OldWarrantyStatus = new StatusInLog();
            WarrantyStatus = new StatusInLog();
        }

        public int Id { get; set; }

        public int CrmId { get; set; }

        public int UserId { get; set; }

        public string Comment { get; set; }

        public DateTime LogDate { get; set; }

        public int OldWarrantyStatusId { get; set; }

        public int WarrantyStatusId { get; set; }

        public List<LogAttachment> Attachments { get; set; }

        public UserInLog User { get; set; }

        public StatusInLog OldWarrantyStatus { get; set; }

        public StatusInLog WarrantyStatus { get; set; }
    }
}
