﻿using BusinessLayer.Abstract;
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
        public EnglishStoriesAdminController(IEnglishStoryDetailsService englishStoryDetailsService, IEnglishStoryService englishStoryService)
        {
            _englishStoryDetailsService = englishStoryDetailsService;
            _englishStoryService = englishStoryService;
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

            //var valueEnglishStory = new EnglishStory()
            //{
            //    EnglishStoryImageUrl= englishUpdateStoryDto.EnglishStoryImageUrl,
            //    EnglishStoryName = englishUpdateStoryDto.EnglishStoryName,
            //};
            //_englishStoryService.TUpdate(valueEnglishStory);

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
            var englishStory = new EnglishStory()
            {
                EnglishStoryName = englishStoryDto.EnglishStoryName,
                EnglishStoryImageUrl = englishStoryDto.EnglishStoryImageUrl,
                EnglishStoryDescription= englishStoryDto.EnglishStoryDescription,
            };

            _englishStoryService.TUpdate(englishStory);
            return RedirectToAction("Index", "EnglishStoriesAdmin");
        }

    }
}
