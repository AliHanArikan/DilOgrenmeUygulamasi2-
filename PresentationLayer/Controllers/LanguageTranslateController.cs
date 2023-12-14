using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class LanguageTranslateController : Controller
    {
        private readonly IEnglishVocabularyService _englishVocabularyService;

        public LanguageTranslateController(IEnglishVocabularyService englishVocabularyService)
        {
            _englishVocabularyService = englishVocabularyService;
        }

        [HttpGet]
        public IActionResult Index()
        {
           var values = _englishVocabularyService.GetAll();   
            return View(values);
        }

        [HttpGet("LanguageTranslate/GetVocabularyWithLevel/{level}")]
        public IActionResult GetVocabularyWithLevel(string level) 
        {
            var values = _englishVocabularyService.TGetEnglishVocabularyWithWordLevel(level);
            return View(values);
        }

        public IActionResult GetSpanishVocabulary()
        {
            return View();
        }

       



        
    }
}
