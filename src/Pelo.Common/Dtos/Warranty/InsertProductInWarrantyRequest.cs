using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Warranty
{
    public class InsertProductInWarrantyRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("warranty_description_id")]
        public int WarrantyDescriptionId { get; set; }

        [JsonProperty("serialnumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
