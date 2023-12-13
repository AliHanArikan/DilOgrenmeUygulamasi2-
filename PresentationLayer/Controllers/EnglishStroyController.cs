using BusinessLayer.Abstract;
using EntityLayer.Exceptions;
using EntityLayer.RequestFeatures;
using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace PresentationLayer.Controllers
{
    //[ResponseCache(CacheProfileName ="5mins")]
    //[HttpCacheExpiration(CacheLocation =CacheLocation.Public, MaxAge= 80)]
    [AllowAnonymous]
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

        [HttpGet]
        public IActionResult Index2()
        {
             EnglishStoriesParameters englishStoriesParameters = new EnglishStoriesParameters();
            englishStoriesParameters.PagesSize = 4;
            englishStoriesParameters.PageNumber = 1;
            
            var pagedResult = _storyService.TGetAllBooksWithPaged(englishStoriesParameters);
            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagedResult.Result.metaData));
            return View(pagedResult.Result.Item1);
        }

        [HttpPost]
        public IActionResult Index2(EnglishStoriesParameters englishStoriesParameters)
        {
            
            var values = _storyService.TGetAllBooksWithPaged(englishStoriesParameters);
            return View(values);
        }
    }
}
