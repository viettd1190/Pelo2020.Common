using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.ProductStatus
{
    public class GetProductStatusPagingResponse
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name{ get; set; }

    }
}
