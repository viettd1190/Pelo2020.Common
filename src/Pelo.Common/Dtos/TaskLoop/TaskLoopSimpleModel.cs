using Newtonsoft.Json;

namespace Pelo.Common.Dtos.TaskLoop
{
    public class TaskLoopSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
