using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class EnglishExamController : Controller
    {
        private readonly IEnglishExamContentService _englishexamContentService;

        public EnglishExamController(IEnglishExamContentService englishexamContentService)
        {
            _englishexamContentService = englishexamContentService;
        }

        
        [HttpGet("EnglishExam/Index/{name}")]
        public IActionResult Index(string name)
        {
            var values = _englishexamContentService.TGetEnglishExamContentListWithStoryName(name);
            return View(values);
        }
    }
}
