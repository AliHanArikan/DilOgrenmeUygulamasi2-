using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class FirstPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
