using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Task
{
    public class GetTaskPagingRequest : GetPagingModel
    {
        [JsonProperty("name")]
        [FromQuery(Name = "name")]
        public string Name { get; set; }

        [JsonProperty("customer_name")]
        [FromQuery(Name = "customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("phone")]
        [FromQuery(Name = "phone")]
        public string Phone { get; set; }

        [JsonProperty("code")]
        [FromQuery(Name = "code")]
        public string Code { get; set; }

        [JsonProperty("task_status_id")]
        [FromQuery(Name = "task_status_id")]
        public int TaskStatusId { get; set; }

        [JsonProperty("task_priority_id")]
        [FromQuery(Name = "task_priority_id")]
        public int TaskPriorityId { get; set; }

        [JsonProperty("task_loop_id")]
        [FromQuery(Name = "task_loop_id")]
        public int TaskLoopId { get; set; }

        [JsonProperty("task_type_id")]
        [FromQuery(Name = "task_type_id")]
        public int TaskTypeId { get; set; }

        [JsonProperty("user_created_id")]
        [FromQuery(Name = "user_created_id")]
        public int UserCreatedId { get; set; }

        [JsonProperty("user_care_id")]
        [FromQuery(Name = "user_care_id")]
        public int UserCareId { get; set; }

        [JsonProperty("from_date")]
        [FromQuery(Name = "from_date")]
        public DateTime FromDate { get; set; }

        [JsonProperty("to_date")]
        [FromQuery(Name = "to_date")]
        public DateTime ToDate { get; set; }
    }
}
