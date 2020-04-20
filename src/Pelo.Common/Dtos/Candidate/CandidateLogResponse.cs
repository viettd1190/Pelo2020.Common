using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Candidate
{
    public class CandidateLogResponse
    {
        public CandidateLogResponse()
        {
            Attachments = new List<LogAttachment>();
            User = new UserInLog();
            OldCandidateStatus = new StatusInLog();
            CandidateStatus = new StatusInLog();
        }

        public int Id { get; set; }

        public int CandidateId { get; set; }

        public int UserId { get; set; }

        public string Comment { get; set; }

        public DateTime LogDate { get; set; }

        public int OldCandidateStatusId { get; set; }

        public int CandidateStatusId { get; set; }

        public List<LogAttachment> Attachments { get; set; }

        public UserInLog User { get; set; }

        public StatusInLog OldCandidateStatus { get; set; }

        public StatusInLog CandidateStatus { get; set; }
    }
    public class CandidateStatusInLog
    {

    }
}
