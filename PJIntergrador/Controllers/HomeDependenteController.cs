using Microsoft.AspNetCore.Mvc;

namespace PJIntergrador.Controllers
{
    public class HomeDependenteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
