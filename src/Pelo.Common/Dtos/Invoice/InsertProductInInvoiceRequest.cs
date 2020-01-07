using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Invoice
{
    public class InsertProductInInvoiceRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
