using Microsoft.AspNetCore.Mvc;

namespace MilkyProjectWebUI.Areas.Admin.ViewComponents
{
    public class _AdminHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
