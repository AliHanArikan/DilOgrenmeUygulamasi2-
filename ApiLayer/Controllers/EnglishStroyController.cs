using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    public class EnglishStroyController : Controller
    {
        private readonly IEnglishStoryService _englishStoryService;

        public EnglishStroyController(IEnglishStoryService englishStoryService)
        {
            _englishStoryService = englishStoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _englishStoryService.GetAll();
            return View(values);
        }
    }
}
