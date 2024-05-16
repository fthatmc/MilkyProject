using Microsoft.AspNetCore.Mvc;

namespace MilkyProjectWebUI.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
