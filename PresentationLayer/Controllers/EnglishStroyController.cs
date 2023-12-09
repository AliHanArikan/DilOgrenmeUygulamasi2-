using BusinessLayer.Abstract;
using EntityLayer.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class EnglishStroyController : Controller
    {
        private readonly IEnglishStoryService _storyService;
        private readonly IEnglishStoryDetailsService _storyDetailsService;
       

        public EnglishStroyController(IEnglishStoryService storyService, IEnglishStoryDetailsService storyDetailsService)
        {
            _storyService = storyService;
            _storyDetailsService = storyDetailsService;
            
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _storyService.GetAll();
            return View(values);
        }

       

        
        
        public IActionResult EnglishStoryDetails2(int id)
        {
            
                
            var valueName = _storyService.TGetByID(id).EnglishStoryName;
            var valueStroies = _storyDetailsService.TGetEnglishStoryDetailsWithStoryName(valueName);
            if (valueName is null)
            {
                throw new EnglishStoryDetailsNotFound(id);
            }

            ViewBag.x = valueStroies.EnglishStoryDetailsName;
             return View(valueStroies);
           
            
        }

        public IActionResult Index2()
        {
            var values = _storyService.GetAll();
            return View(values);
        }
    }
}
