using Newtonsoft.Json;

namespace Pelo.Common.Dtos.CustomerSource
{
    public class CustomerSourceSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
