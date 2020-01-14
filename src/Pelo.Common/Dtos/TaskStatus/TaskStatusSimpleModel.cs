using Newtonsoft.Json;

namespace Pelo.Common.Dtos.TaskStatus
{
    public class TaskStatusSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
