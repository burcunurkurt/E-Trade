using Microsoft.AspNetCore.Mvc;

namespace Abc.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
