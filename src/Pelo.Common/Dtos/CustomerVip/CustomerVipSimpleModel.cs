using Newtonsoft.Json;

namespace Pelo.Common.Dtos.CustomerVip
{
    public class CustomerVipSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
