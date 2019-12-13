using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;

namespace Pelo.Common.Dtos.User
{
    public class GetUserPagingRequest : GetPagingModel
    {
        /// <summary>
        ///     Mã nhân viên
        /// </summary>
        [JsonProperty("code")]
        [FromQuery(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        ///     Tên nhân viên
        /// </summary>
        [JsonProperty("full_name")]
        [FromQuery(Name = "full_name")]
        public string FullName { get; set; }

        /// <summary>
        ///     Số điện thoại
        /// </summary>
        [JsonProperty("phone_number")]
        [FromQuery(Name = "phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        ///     Chi nhánh
        /// </summary>
        [JsonProperty("branch_id")]
        [FromQuery(Name = "branch_id")]
        public int BranchId { get; set; }

        /// <summary>
        ///     Phòng ban
        /// </summary>
        [JsonProperty("department_id")]
        [FromQuery(Name = "department_id")]
        public int DepartmentId { get; set; }

        /// <summary>
        ///     Nhóm quyền
        /// </summary>
        [JsonProperty("role_id")]
        [FromQuery(Name = "role_id")]
        public int RoleId { get; set; }

        /// <summary>
        ///     Trạng thái
        /// </summary>
        [JsonProperty("status")]
        [FromQuery(Name = "status")]
        public int Status { get; set; }
    }
}
