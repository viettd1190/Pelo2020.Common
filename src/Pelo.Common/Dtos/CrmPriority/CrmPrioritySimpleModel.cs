using Newtonsoft.Json;

namespace Pelo.Common.Dtos.CrmPriority
{
    public class CrmPrioritySimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
