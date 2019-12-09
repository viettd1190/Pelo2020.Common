using System;
using Newtonsoft.Json;

namespace Pelo.Common.Models
{
    public class LogModel
    {
        [JsonProperty("request_time")]
        public DateTime RequestTime { get; set; }

        [JsonProperty("response_millis")]
        public long ResponseMillis { get; set; }

        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("query_string")]
        public string QueryString { get; set; }

        [JsonProperty("request_body")]
        public string RequestBody { get; set; }

        [JsonProperty("response_body")]
        public string ResponseBody { get; set; }
    }
}