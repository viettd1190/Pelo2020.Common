using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Events.Candidate
{
    public class CandidateCommentSuccessEvent : IEvent
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public int CandidateStatusId { get; set; }

        public int UserId { get; set; }

        public string Comment { get; set; }

        public bool HasAttachmentFile { get; set; }
    }
}
