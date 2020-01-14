using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.ProductUnit
{
    public class GetProductUnitPagingResponse
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name{ get; set; }

    }
}
