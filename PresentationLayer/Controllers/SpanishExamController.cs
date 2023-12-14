using BusinessLayer.Abstract;
using BusinessLayer.Abstract.Spanish;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class SpanishExamController : Controller
    {
        private readonly ISpanishExamService _spanishExamService;
        private readonly IEnglishExamContentService _englishExamContentService;

        public SpanishExamController(ISpanishExamService spanishExamService, IEnglishExamContentService englishExamContentService)
        {
            _spanishExamService = spanishExamService;
            _englishExamContentService = englishExamContentService;
        }

        public IActionResult Index()
        {
            var values = _spanishExamService.GetAll();
            return View(values);
        }

       
    }
}
