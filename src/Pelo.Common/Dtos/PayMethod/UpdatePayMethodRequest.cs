using Newtonsoft.Json;

namespace Pelo.Common.Dtos.PayMethod
{
    public class UpdatePayMethodRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
