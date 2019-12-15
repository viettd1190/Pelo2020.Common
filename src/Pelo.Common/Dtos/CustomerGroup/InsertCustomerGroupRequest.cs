using Newtonsoft.Json;

namespace Pelo.Common.Dtos.CustomerGroup
{
    public class InsertCustomerGroupRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
