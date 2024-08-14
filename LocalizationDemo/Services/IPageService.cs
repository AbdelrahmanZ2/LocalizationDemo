using LocalizationDemo.Models;
using static LocalizationDemo.Models.Enum;

namespace LocalizationDemo.Services
{
    public interface IPageService
    {
        Dictionary<string, string> GetValuesByKeys(List<string> keys, Language language);
    }
}
