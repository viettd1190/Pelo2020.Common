using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Receipt
{
    public class ProductInReceiptRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("receipt_description_id")]
        public int ReceiptDescriptionId { get; set; }

        [JsonProperty("serialnumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
