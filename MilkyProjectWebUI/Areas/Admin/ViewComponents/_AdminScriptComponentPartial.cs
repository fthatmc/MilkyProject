using Microsoft.AspNetCore.Mvc;

namespace MilkyProjectWebUI.Areas.Admin.ViewComponents
{
    public class _AdminScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
