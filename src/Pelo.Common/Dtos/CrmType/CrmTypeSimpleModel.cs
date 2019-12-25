using Newtonsoft.Json;

namespace Pelo.Common.Dtos.CrmType
{
    public class CrmTypeSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
