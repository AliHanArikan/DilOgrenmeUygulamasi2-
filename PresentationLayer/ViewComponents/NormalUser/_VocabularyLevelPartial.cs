using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.NormalUser
{
    public class _VocabularyLevelPartial : ViewComponent
    {
        private readonly IEnglishVocabularyService _englishVocabularyService;

        public _VocabularyLevelPartial(IEnglishVocabularyService englishVocabularyService)
        {
            _englishVocabularyService = englishVocabularyService;
        }

       

        public IViewComponentResult Invoke(string levelName)
        {
            var values = _englishVocabularyService.TGetEnglishVocabularyWithWordLevel(levelName);
            return View(values);
        }
    }
}
