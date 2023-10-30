using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnglishStoryController : ControllerBase
    {
        private readonly IEnglishStoryService _englishStoryService;

        public EnglishStoryController(IEnglishStoryService englishStoryService)
        {
            _englishStoryService = englishStoryService;
        }

        [HttpGet]
        public IEnumerable<EnglishStory> GetAll()
        {
            var values = _englishStoryService.GetAll();
            return values;
        }
    }
}
