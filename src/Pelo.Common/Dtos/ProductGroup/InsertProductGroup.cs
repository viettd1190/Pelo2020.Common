using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.ProductGroup
{
    public class InsertProductGroup
    {

        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

    }
}
