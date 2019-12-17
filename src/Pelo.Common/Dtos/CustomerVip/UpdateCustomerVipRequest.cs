using Newtonsoft.Json;

namespace Pelo.Common.Dtos.CustomerVip
{
    public class UpdateCustomerVipRequest : InsertCustomerVipRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
