using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;

namespace Pelo.Common.Dtos.Ward
{
    public class GetWardPagingRequest : GetPagingModel
    {
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("province_id")]
        [FromQuery(Name = "province_id")]
        public int ProvinceId { get; set; }

        [JsonProperty("district_id")]
        [FromQuery(Name = "district_id")]
        public int DistrictId { get; set; }
    }
}
