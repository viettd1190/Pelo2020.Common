using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;

namespace Pelo.Common.Dtos.User
{
    public class GetUserPagingRequest : GetPagingModel
    {
        [JsonProperty("username")] 
        [FromQuery(Name="username")]
        public string Username { get; set; }

        [JsonProperty("display_name")]
        [FromQuery(Name = "display_name")] 
        public string DisplayName { get; set; }

        [JsonProperty("full_name")]
        [FromQuery(Name = "full_name")] 
        public string FullName { get; set; }

        [JsonProperty("phone_number")]
        [FromQuery(Name = "phone_number")] 
        public string PhoneNumber { get; set; }

        [JsonProperty("branch_id")]
        [FromQuery(Name = "branch_id")] 
        public int BranchId { get; set; }

        [JsonProperty("role_id")]
        [FromQuery(Name = "role_id")] 
        public int RoleId { get; set; }
    }
}