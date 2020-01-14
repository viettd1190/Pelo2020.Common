using Newtonsoft.Json;

namespace Pelo.Common.Dtos.ReceiptStatus
{
    public class ReceiptStatusSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
