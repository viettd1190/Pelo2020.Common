using Newtonsoft.Json;

namespace Pelo.Common.Dtos.PayMethod
{
    public class InsertPayMethod
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
