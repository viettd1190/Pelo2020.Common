using System.Collections.Generic;

namespace Pelo.Common.Events.Crm
{
    public class CrmInsertSuccessEvent : IEvent
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public int UserId { get; set; }

        public int CrmStatusId { get; set; }

        /// <summary>
        ///     Danh sách user nhận thông báo khi crm mới được thêm
        /// </summary>
        public List<int> UserIds { get; set; }
    }
}
