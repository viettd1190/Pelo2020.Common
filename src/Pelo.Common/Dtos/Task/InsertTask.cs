using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Task
{
    public class InsertTask
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("customer_id")] public int CustomerId{ get; set; }

        [JsonProperty("content")] public string Content { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("task_status_id")] public string TaskStatusId { get; set; }

        [JsonProperty("task_priority_id")] public string TaskPriorityId{ get; set; }

        [JsonProperty("task_loop_id")] public string TaskLoopId{ get; set; }

        [JsonProperty("task_type_id")] public string TaskTypeId { get; set; }

        [JsonProperty("from_date_time")] public DateTime FromDateTime { get; set; }

        [JsonProperty("to_date_time")] public DateTime ToDateTime { get; set; }
    }
}
