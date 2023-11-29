using Microsoft.AspNetCore.Mvc;

namespace PJIntergrador.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
