﻿using Newtonsoft.Json;

namespace Pelo.Common.Dtos.CustomerGroup
{
    public class GetCustomerGroupPagingResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}