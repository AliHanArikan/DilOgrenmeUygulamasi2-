using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.AdminArea.Controllers
{
    public class AdminMainPage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
