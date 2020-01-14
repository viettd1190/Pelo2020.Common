﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Branch
{
    public class GetBranchPagingRequest : GetPagingModel
    {
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("province_id")]
        [FromQuery(Name = "province_id")]
        public int ProvinceId { get; set; }

        [JsonProperty("hotline")]
        [FromQuery(Name = "hotline")]
        public string Hotline { get; set; }

        [JsonProperty("district_id")]
        [FromQuery(Name = "district_id")]
        public int DistrictId { get; set; }

        [JsonProperty("ward_id")]
        [FromQuery(Name = "ward_id")]
        public int WardId { get; set; }
    }
}
