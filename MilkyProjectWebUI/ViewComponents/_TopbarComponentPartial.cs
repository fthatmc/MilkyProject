using Microsoft.AspNetCore.Mvc;

namespace MilkyProjectWebUI.ViewComponents
{
    public class _TopbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
