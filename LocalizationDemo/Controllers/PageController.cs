using LocalizationDemo.Requests;
using LocalizationDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using static LocalizationDemo.Models.Enum;

namespace LocalizationDemo.Controllers
{
    [ApiController]
    [Route("Page")]
    public class PageController : ControllerBase
    {
        private readonly IPageService _pageService;

        public PageController(IPageService pageService)
        {
            _pageService = pageService;
        }

        [HttpGet("GetPageLayout")]
        public IActionResult GetPageLayout([FromQuery] GetPageLayoutRequest request)
        {
            var result = _pageService.GetPageLayout(request.PageId, request.Language);
            return Ok(result);
        }

        [HttpPost("GetValuesByKeys")]
        public IActionResult GetValuesByKeys([FromBody] List<string> keys)
        {
            var userLang = Language.JP; // mocking for claims
            var result = _pageService.GetValuesByKeys(keys, userLang);
            return Ok(result);
        }
    }
}
