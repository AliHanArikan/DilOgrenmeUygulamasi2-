using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.StoryDetails
{
    public class _StoryDetailsLayoutHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
