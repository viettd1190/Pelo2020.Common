using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Country
{
    public class UpdateCountry
    {
        [JsonProperty("id")]
        [FromQuery(Name = "id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        [FromQuery(Name = "code")]
        public string Code { get; set; }

        [JsonProperty("region")]
        [FromQuery(Name = "region")]
        public string Region { get; set; }
    }
}
