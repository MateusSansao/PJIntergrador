using Microsoft.AspNetCore.Mvc;

namespace PJIntergrador.Controllers
{
    public class EventoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
