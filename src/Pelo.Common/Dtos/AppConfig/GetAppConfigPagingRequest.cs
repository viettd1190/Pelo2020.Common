using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;

namespace Pelo.Common.Dtos.AppConfig
{
    public class GetAppConfigPagingRequest : GetPagingModel
    {
        /// <summary>
        ///     Tên cấu hình
        /// </summary>
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Mô tả cấu hình
        /// </summary>
        [JsonProperty("description")]
        [FromQuery(Name = "description")]
        public string Description { get; set; }
    }
}
