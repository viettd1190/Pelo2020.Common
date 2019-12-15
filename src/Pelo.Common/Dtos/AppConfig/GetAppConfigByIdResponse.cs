using Newtonsoft.Json;

namespace Pelo.Common.Dtos.AppConfig
{
    public class GetAppConfigByIdResponse : UpdateAppConfigRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
