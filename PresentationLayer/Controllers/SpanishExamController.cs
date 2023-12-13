using BusinessLayer.Abstract.Spanish;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class SpanishExamController : Controller
    {
        private readonly ISpanishExamService _spanishExamService;

        public SpanishExamController(ISpanishExamService spanishExamService)
        {
            _spanishExamService = spanishExamService;
        }

        public IActionResult Index()
        {
            var values = _spanishExamService.GetAll();
            return View(values);
        }
    }
}
