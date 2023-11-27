using BusinessLayer.Abstract.Spanish;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class SpanishStoryController : Controller
    {
        private readonly ISpanishStoryService _spanishStoryService;

        public SpanishStoryController(ISpanishStoryService spanishStoryService)
        {
            _spanishStoryService = spanishStoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _spanishStoryService.GetAll();
            return View(values);
        }
    }
}
