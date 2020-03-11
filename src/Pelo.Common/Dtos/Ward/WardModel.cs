using Newtonsoft.Json;

namespace Pelo.Common.Dtos.Ward
{
    public class WardModel
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public int DistrictId { get; set; }

        public int ProvinceId { get; set; }

        public int SortOrder { get; set; }

    }
}
