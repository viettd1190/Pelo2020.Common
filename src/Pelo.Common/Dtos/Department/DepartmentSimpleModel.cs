using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Department
{
    public class DepartmentSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}