using DtoLayer.Dtos.AdminDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.AdminArea.Controllers
{
    [AllowAnonymous]
    [Area("AdminArea")]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AdminLoginDto adminLoginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(adminLoginDto.userName, adminLoginDto.password, false, true);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(adminLoginDto.userName);
                
                    return RedirectToAction("Index", "EnglishStoriesAdmin", new { Area = "AdminArea" });
                
                
            }
           
            return View();
        }
    }
}
