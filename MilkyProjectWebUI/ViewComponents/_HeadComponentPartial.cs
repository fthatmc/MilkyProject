using Microsoft.AspNetCore.Mvc;

namespace MilkyProjectWebUI.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
