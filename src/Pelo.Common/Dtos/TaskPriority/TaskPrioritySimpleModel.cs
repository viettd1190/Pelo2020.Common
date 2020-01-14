using Newtonsoft.Json;

namespace Pelo.Common.Dtos.TaskPriority
{
    public class TaskPrioritySimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
