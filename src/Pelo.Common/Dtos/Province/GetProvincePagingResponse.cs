using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Province
{
    public class GetProvincePagingResponse
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name{ get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

    }
}
