using Microsoft.AspNetCore.Mvc;

namespace MilkyProjectWebUI.Areas.Admin.ViewComponents
{
    public class _AdminNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
