using Newtonsoft.Json;
using Pelo.Common.Dtos.User;
using System.Collections.Generic;

namespace Pelo.Common.Dtos.Task
{
    public class TaskSimpleModel
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("status_color")] public string StatusColor { get; set; }

        [JsonProperty("priority_color")] public string PriorityColor { get; set; }

        [JsonProperty("code")] public string Code { get; set; }

        [JsonProperty("task_status_name")] public string TaskStatusName { get; set; }

        [JsonProperty("task_status_id")] public int TaskStatusId { get; set; }

        [JsonProperty("task_priority_name")] public string TaskPriorityName { get; set; }

        [JsonProperty("user_phone_created")] public string UserPhoneCreated { get; set; }

        [JsonProperty("phone")] public string Phone { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("customer_name")] public string CustomerName { get; set; }

        [JsonProperty("customer_phone")] public string CustomerPhone{ get; set; }

        [JsonProperty("user_name_care")] public string UserNameCare { get; set; }

        [JsonProperty("care_users")]
        public List<UserDisplaySimpleModel> CareUsers { get; set; } = new List<UserDisplaySimpleModel>();

        [JsonProperty("concern_users")]
        public List<UserDisplaySimpleModel> ConcernUsers { get; set; } = new List<UserDisplaySimpleModel>();

        [JsonProperty("content")] public string Content { get; set; }

        [JsonProperty("user_name_created")] public string UserNameCreated { get; set; }

        [JsonProperty("task_loop_name")] public string TaskLoopName { get; set; }

        [JsonProperty("from_time")] public string FromTime { get; set; }

        [JsonProperty("end_time")] public string EndTime { get; set; }

        [JsonProperty("name")] public string Address { get; set; }
    }
}
