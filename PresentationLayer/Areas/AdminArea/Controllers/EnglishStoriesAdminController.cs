using BusinessLayer.Abstract;
using DtoLayer.Dtos.EnglishQuestionsDtos;
using DtoLayer.Dtos.EnglishStoryDetailsDtos;
using DtoLayer.Dtos.EnglishStoryDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class EnglishStoriesAdminController : Controller
    {
        private readonly IEnglishStoryDetailsService _englishStoryDetailsService;
        private readonly IEnglishStoryService _englishStoryService;
        private readonly IEnglishExamContentService _englishExamContentService;
        public EnglishStoriesAdminController(IEnglishStoryDetailsService englishStoryDetailsService, IEnglishStoryService englishStoryService, IEnglishExamContentService englishExamContentService)
        {
            _englishStoryDetailsService = englishStoryDetailsService;
            _englishStoryService = englishStoryService;
            _englishExamContentService = englishExamContentService;
        }

        [HttpGet]
        
        public IActionResult Index()
        {
            var values = _englishStoryService.GetAll();
            return View(values);
        }

       
        [HttpGet]
        
       // [Route("UpdateStoryDetails/{id}")]
        public IActionResult UpdateStoryDetails(int id)
        {
            var valueName = _englishStoryService.TGetByID(id).EnglishStoryName;
            var value = _englishStoryDetailsService.TGetEnglishStoryDetailsWithStoryName(valueName);
            var valueDto = new EnglishUpdateStoryDto()
            {
                EnglishStoryName = value.EnglishStoryDetailsName,
                EnglishStoryImageUrl= value.EnglishStoryImageUrl,
                EnglishStoryDescription= value.EnglishStoryDetailsContent
            };
            return View(valueDto);
        }
        
        [HttpPost]
        
        public IActionResult UpdateStoryDetails(EnglishUpdateStoryDto englishUpdateStoryDto)
        {
            var valueEnglishStoryDetails = new EnglishStoryDetails()
            {
                EnglishStoryDetailsContent = englishUpdateStoryDto.EnglishStoryDescription,
                EnglishStoryDetailsName= englishUpdateStoryDto.EnglishStoryName,
                EnglishStoryImageUrl = englishUpdateStoryDto.EnglishStoryImageUrl,
            };

           

            _englishStoryDetailsService.TUpdate(valueEnglishStoryDetails);
            
            return RedirectToAction("Index", "EnglishStoriesAdmin");
        }

        [HttpGet]
        public IActionResult UpdateStory(int id)
        {
            
            var value = _englishStoryService.TGetByID(id);
            var valueDto = new EnglishStoryDto()
            {
                EnglishStoryName = value.EnglishStoryName,
                EnglishStoryImageUrl = value.EnglishStoryImageUrl,
                EnglishStoryDescription = value.EnglishStoryDescription
            };
            return View(valueDto);
        }

        [HttpPost]
        public IActionResult UpdateStory(EnglishStoryDto englishStoryDto)
        {
            if (ModelState.IsValid)
            {
                var englishStory = new EnglishStory()
                {
                    EnglishStoryName = englishStoryDto.EnglishStoryName,
                    EnglishStoryImageUrl = englishStoryDto.EnglishStoryImageUrl,
                    EnglishStoryDescription = englishStoryDto.EnglishStoryDescription,
                };

                _englishStoryService.TUpdate(englishStory);
                return RedirectToAction("Index", "EnglishStoriesAdmin");
            }
            return View();
            
        }

        [HttpGet]
        public IActionResult UpdateQuestions(int id)
        {
            var valueName = _englishStoryService.TGetByID(id).EnglishStoryName;
            var values = _englishExamContentService.TGetEnglishExamContentListWithStoryName(valueName);
            return View(values);

        }


    }
}
