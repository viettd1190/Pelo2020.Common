using Newtonsoft.Json;
using Pelo.Common.Extensions;

namespace Pelo.Common.Models
{
    public class GetPagingModel
    {
        private string _columnOrder = "Id";

        [JsonProperty("column_order")]
        public string ColumnOrder
        {
            get => _columnOrder.ToColumnName();
            set => _columnOrder = value;
        }

        [JsonProperty("sort_dir")]
        public string SortDir { get; set; } = "ASC";

        [JsonProperty("page")]
        public int Page { get; set; } = 1;

        [JsonProperty("page_size")]
        public int PageSize { get; set; } = 10;
    }
}