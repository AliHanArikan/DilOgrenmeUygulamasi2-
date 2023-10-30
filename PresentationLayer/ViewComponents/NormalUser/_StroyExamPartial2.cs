using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.NormalUser
{
    public class _StroyExamPartial2 : ViewComponent
    {
        private readonly IEnglishExamContentService _englishExamContentService;
        private readonly IEnglishStoryDetailsService _englishStoryDetailsService;

        public _StroyExamPartial2(IEnglishExamContentService englishExamContentService, IEnglishStoryDetailsService englishStoryDetailsService)
        {
            _englishExamContentService = englishExamContentService;
            _englishStoryDetailsService = englishStoryDetailsService;
        }

        public IViewComponentResult Invoke(string name)
        {
           //var valueName =_englishStoryDetailsService.TGetByID(id);
          var values= _englishExamContentService.TGetEnglishExamContentListWithStoryName(name);
            
            return View(values);
        }
    }
}
