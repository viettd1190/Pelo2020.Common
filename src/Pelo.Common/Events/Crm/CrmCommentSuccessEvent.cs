namespace Pelo.Common.Events.Crm
{
    public class CrmCommentSuccessEvent : IEvent
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public int CrmStatusId { get; set; }

        public int UserId { get; set; }

        public string Comment { get; set; }

        public bool HasAttachmentFile { get; set; }
    }
}
