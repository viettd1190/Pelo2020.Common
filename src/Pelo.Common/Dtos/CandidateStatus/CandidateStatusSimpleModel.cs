using Newtonsoft.Json;

namespace Pelo.Common.Dtos.CandidateStatus
{
    public class CandidateStatusSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
