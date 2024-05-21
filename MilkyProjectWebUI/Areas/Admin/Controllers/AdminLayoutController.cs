using Microsoft.AspNetCore.Mvc;

namespace MilkyProjectWebUI.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
