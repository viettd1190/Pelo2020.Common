using Newtonsoft.Json;

namespace Pelo.Common.Dtos.CustomerVip
{
    public class InsertCustomerVipRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("profit")]
        public int Profit { get; set; }

        [JsonProperty("sortOder")]
        public int SortOder { get; set; }
    }
}
