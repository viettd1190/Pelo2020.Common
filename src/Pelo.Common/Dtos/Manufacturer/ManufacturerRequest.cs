﻿using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Manufacturer
{
    public class UpdateManufacturerRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
