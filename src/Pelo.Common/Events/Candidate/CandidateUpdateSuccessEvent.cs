using System;
using System.Collections.Generic;

namespace Pelo.Common.Events.Crm
{
    public class CandidateUpdateSuccessEvent : IEvent
    {
        public CandidateUpdateSuccessModel BeforeUpdated { get; set; }

        public CandidateUpdateSuccessModel AfterUpdated { get; set; }

        public int Id { get; set; }

        public string Code { get; set; }

        public int UserId { get; set; }

    }

    public class CandidateUpdateSuccessModel
    {
        public int CandidateStatusId { get; set; }

    }
}
