using Newtonsoft.Json;

namespace Pelo.Common.Dtos.RecruitmentStatus
{
    public class RecruitmentStatusSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
