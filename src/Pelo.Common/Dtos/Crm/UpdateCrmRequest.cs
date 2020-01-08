﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Crm
{
    public class UpdateCrmRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("crm_status_id")]
        public int CrmStatusId { get; set; }

        [JsonProperty("product_group_id")]
        public int ProductGroupId { get; set; }

        [JsonProperty("crm_proority_id")]
        public int CrmPriorityId { get; set; }

        [JsonProperty("crm_type_id")]
        public int CrmTypeId { get; set; }

        [JsonProperty("customer_source_id")]
        public int CustomerSourceId { get; set; }

        [JsonProperty("user_ids")]
        public List<int> UserIds { get; set; }

        [JsonProperty("visit")]
        public int Visit { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("contact_date")]
        public DateTime ContactDate { get; set; }

    }
}
