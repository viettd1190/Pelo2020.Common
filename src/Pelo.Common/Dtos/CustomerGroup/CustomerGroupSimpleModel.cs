using Newtonsoft.Json;

namespace Pelo.Common.Dtos.CustomerGroup
{
    public class CustomerGroupSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
