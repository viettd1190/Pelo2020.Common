using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;

namespace Pelo.Common.Dtos.CustomerGroup
{
    public class GetCustomerGroupPagingRequest : GetPagingModel
    {
        /// <summary>
        ///     Tên nhóm khách hàng
        /// </summary>
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }
    }
}
