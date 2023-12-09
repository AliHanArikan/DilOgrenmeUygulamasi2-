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
        private readonly IEnglishStoryDetailsService _englishStoryDetailsService;

        public EnglishStoryController(IEnglishStoryService englishStoryService, IEnglishStoryDetailsService englishStoryDetailsService)
        {
            _englishStoryService = englishStoryService;
            _englishStoryDetailsService = englishStoryDetailsService;
        }

        [HttpGet]
        public IEnumerable<EnglishStory> GetAll()
        {
            
            var values = _englishStoryService.GetAll();
            return values;
        }

        [HttpGet("{id: int}")]
        public IActionResult GetOneEnglishStory(int id)
        {
            try
            {
               var englishStoryDetail= _englishStoryDetailsService.TGetByID(id);
                return Ok(englishStoryDetail);
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
