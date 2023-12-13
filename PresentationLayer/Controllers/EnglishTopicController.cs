using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    //[ResponseCache(CacheProfileName="5mins")]
    [AllowAnonymous]
    public class EnglishTopicController : Controller
    {
        private readonly IEnglishTopicNameService _englishTopicNameService;
        private readonly IEnglishLessonContentService _englishLessonContentService;

        public EnglishTopicController(IEnglishTopicNameService englishTopicNameService, IEnglishLessonContentService englishLessonContentService)
        {
            _englishTopicNameService = englishTopicNameService;
            _englishLessonContentService = englishLessonContentService;
        }

        //[ResponseCache(Duration = 60)]
        public IActionResult Index()
        {
            var values = _englishTopicNameService.GetAll();
            return View(values);
        }

        
        public IActionResult LessonContentDetail(int id)
        {
            var valueName = _englishTopicNameService.TGetByID(id).EnglishTopicName;
            var value = _englishLessonContentService.TGetEnglishLessonWithEnglishLessonName(valueName);
            return View(value);
        }
    }
}
