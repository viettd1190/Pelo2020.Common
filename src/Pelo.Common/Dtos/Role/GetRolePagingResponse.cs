using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Role
{
    public class GetRolePagingResponse
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name{ get; set; }

    }
}
