using Newtonsoft.Json;

namespace Pelo.Common.Dtos.PayMethod
{
    public class InsertPayMethodRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
