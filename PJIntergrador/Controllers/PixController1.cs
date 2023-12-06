using Microsoft.AspNetCore.Mvc;

namespace PJIntergrador.Controllers
{
    public class PixController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
