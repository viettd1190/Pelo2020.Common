using Newtonsoft.Json;

namespace Pelo.Common.Dtos.CustomerVip
{
    public class GetCustomerVipPagingResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("profit")]
        public int Profit { get; set; }
    }
}