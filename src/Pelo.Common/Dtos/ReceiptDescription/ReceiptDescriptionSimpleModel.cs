using Newtonsoft.Json;

namespace Pelo.Common.Dtos.ReceiptDescription
{
    public class ReceiptDescriptionSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}