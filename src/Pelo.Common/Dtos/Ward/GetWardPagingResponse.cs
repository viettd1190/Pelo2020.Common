using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Ward
{
    public class GetWardPagingResponse
    {
        [JsonProperty("Id")] public int Id { get; set; }

        [JsonProperty("Name")] public string Name { get; set; }

        [JsonProperty("District")] public string District { get; set; }

        [JsonProperty("Province")] public string Province { get; set; }

        [JsonProperty("Type")] public string Type { get; set; }

        [JsonProperty("SortOrder")] public int SortOrder { get; set; }
    }
}
