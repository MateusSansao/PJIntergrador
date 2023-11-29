using Microsoft.AspNetCore.Mvc;

namespace PJIntergrador.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
