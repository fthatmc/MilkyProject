using Microsoft.AspNetCore.Mvc;

namespace MilkyProjectWebUI.Areas.Admin.ViewComponents
{
    public class _AdminSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
