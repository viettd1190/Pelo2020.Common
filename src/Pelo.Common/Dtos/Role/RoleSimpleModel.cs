using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Role
{
    public class RoleSimpleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}