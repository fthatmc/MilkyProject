using Microsoft.AspNetCore.Mvc;

namespace MilkyProjectWebUI.ViewComponents
{
    public class _ScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
