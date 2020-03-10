namespace Pelo.Common.Events.Invoice
{
    public class InvoiceInsertSuccessEvent : IEvent
    {
        public int Id { get; set; }

        public string Code { get; set; }
    }
}
