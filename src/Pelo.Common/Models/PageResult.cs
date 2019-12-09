using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pelo.Common.Models
{
    public class PageResult<T>
    {
        public PageResult()
        {
        }

        public PageResult(int page,
            int pageSize) : this()
        {
            Page = page;
            PageSize = pageSize;
            TotalCount = 0;
            Data = null;
        }

        public PageResult(int page,
            int pageSize,
            int totalCount,
            IEnumerable<T> data) : this(page,
            pageSize)
        {
            TotalCount = totalCount;
            Data = data;
        }

        [JsonProperty("data")]
        public IEnumerable<T> Data { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }
}