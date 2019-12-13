using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Branch
{
    public class BranchSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}