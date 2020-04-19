using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Events.Warranty
{
    public class WarrantyInsertSuccessEvent : IEvent
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public int WarrantyStatusId { get; set; }

        public int UserId { get; set; }

        public int CustomerId { get; set; }
    }
}
