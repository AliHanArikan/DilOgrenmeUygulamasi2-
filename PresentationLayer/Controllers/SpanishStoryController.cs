using BusinessLayer.Abstract.Spanish;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class SpanishStoryController : Controller
    {
        private readonly ISpanishStoryService _spanishStoryService;
        private readonly ISpanishStoryDetailService _spanishStoryDetailService;

        public SpanishStoryController(ISpanishStoryService spanishStoryService, ISpanishStoryDetailService spanishStoryDetailService)
        {
            _spanishStoryService = spanishStoryService;
            _spanishStoryDetailService = spanishStoryDetailService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _spanishStoryService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult SpanishStoryDetail(int id)
        {
            var storyName = _spanishStoryService.TGetByID(id).SpanishStoryName;
            var storyDetail = _spanishStoryDetailService.TGetSpanishStoryWithStoryName(storyName);

            return View(storyDetail);
        }
    }
}
