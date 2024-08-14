using static LocalizationDemo.Models.Enum;

namespace LocalizationDemo.Requests
{
    public class GetPageLayoutRequest
    {
        public int PageId {  get; set; }
        public Language Language { get; set; }
    }
}
