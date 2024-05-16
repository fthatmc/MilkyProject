using Microsoft.AspNetCore.Mvc;

namespace MilkyProjectWebUI.ViewComponents
{
    public class _CarouselComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
