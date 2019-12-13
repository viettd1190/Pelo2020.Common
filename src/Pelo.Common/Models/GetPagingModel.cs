using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pelo.Common.Extensions;

namespace Pelo.Common.Models
{
    public class GetPagingModel
    {
        private string _columnOrder = "Id";

        [JsonProperty("column_order")]
        [FromQuery(Name = "column_order")]
        public string ColumnOrder
        {
            get => _columnOrder.ToColumnName();
            set => _columnOrder = value;
        }

        [JsonProperty("sort_dir")]
        [FromQuery(Name = "sort_dir")]
        public string SortDir { get; set; } = "ASC";

        [JsonProperty("page")]
        [FromQuery(Name = "page")]
        public int Page { get; set; } = 1;

        [JsonProperty("page_size")]
        [FromQuery(Name = "page_size")]
        public int PageSize { get; set; } = 10;
    }
}