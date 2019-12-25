using Newtonsoft.Json;

namespace Pelo.Common.Dtos.CrmStatus
{
    public class CrmStatusSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
