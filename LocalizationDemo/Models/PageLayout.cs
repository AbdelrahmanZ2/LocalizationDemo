using Microsoft.AspNetCore.Mvc.Razor;
using static LocalizationDemo.Models.Enum;

namespace LocalizationDemo.Models
{
    public class PageLayout
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public string key { get; set; }
        public string Value { get; set; }
        public Language Language { get; set; }

    }
}
