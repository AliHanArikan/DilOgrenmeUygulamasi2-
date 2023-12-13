using AutoMapper;
using DtoLayer.Dtos.AdminDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class RegisterController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public RegisterController(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpGet]
        [Area("AdminArea")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AdminRegisterDto adminRegisterDto)
        {
            if(ModelState.IsValid)
            {
                AppUser appUser = _mapper.Map<AppUser>(adminRegisterDto);
                var result = await _userManager.CreateAsync(appUser,adminRegisterDto.Password);

                if(result.Succeeded)
                {
                    RedirectToAction("EnglishStoriesAdmin","Index");

                }
            }
           
            return View();
        }
    }
}
