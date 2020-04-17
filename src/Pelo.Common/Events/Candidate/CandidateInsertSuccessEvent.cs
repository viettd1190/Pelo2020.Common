using System.Collections.Generic;

namespace Pelo.Common.Events.Candidate
{
    public class CandidateInsertSuccessEvent : IEvent
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public int UserId { get; set; }

        public int CandidateStatusId { get; set; }

        /// <summary>
        ///     Danh sách user nhận thông báo khi crm mới được thêm
        /// </summary>
        public List<int> UserIds { get; set; }
    }
}
