using Microsoft.AspNetCore.Mvc;

namespace MilkyProjectWebUI.Controllers
{
    public class MilkyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
