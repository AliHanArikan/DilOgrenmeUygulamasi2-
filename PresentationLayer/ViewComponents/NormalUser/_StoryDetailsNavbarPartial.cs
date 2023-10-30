using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.NormalUser
{
    public class _StoryDetailsNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
