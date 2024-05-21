using Microsoft.AspNetCore.Mvc;

namespace MilkyProjectWebUI.Areas.Admin.ViewComponents
{
    public class _AdminFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
