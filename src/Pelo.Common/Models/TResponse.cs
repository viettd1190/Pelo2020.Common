using Newtonsoft.Json;

namespace Pelo.Common.Models
{
    /// <summary>
    ///     TResponse
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TResponse<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}