using Newtonsoft.Json;

namespace Pelo.Common.Dtos.CustomerGroup
{
    public class UpdateCustomerGroupRequest : InsertCustomerGroupRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
