using Newtonsoft.Json;

namespace Pelo.Common.Dtos.PayMethod
{
    public class GetPayMethodPagingResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
