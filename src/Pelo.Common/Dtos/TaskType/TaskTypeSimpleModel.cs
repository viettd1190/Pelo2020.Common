using Newtonsoft.Json;

namespace Pelo.Common.Dtos.TaskType
{
    public class TaskTypeSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
