using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Country
{
    public class GetCountryPagingResponse
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

    }
}
