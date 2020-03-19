namespace Pelo.Common.Events.Invoice
{
    public class InvoiceInsertSuccessEvent : IEvent
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public int InvoiceStatusId { get; set; }

        public int UserId { get; set; }

        public int CustomerId { get; set; }
    }
}
