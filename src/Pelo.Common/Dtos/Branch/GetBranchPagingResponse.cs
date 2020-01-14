using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Branch
{
    public class GetBranchPagingResponse
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name{ get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("hotline")]
        public string Hotline { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("ward_id")]
        public string Ward { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
