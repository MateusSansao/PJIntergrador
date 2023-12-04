using Microsoft.AspNetCore.Mvc;
using PJIntergrador.Data.Repositorio.Interfaces;

namespace PJIntergrador.Controllers
{
    public class PerfilController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ISociosRepositorio _sociosrepositorio;
        public PerfilController(IConfiguration configuration, ISociosRepositorio sociosrepositorio)
        {

            _configuration = configuration;
            _sociosrepositorio = sociosrepositorio;
        }
        public IActionResult Index()
        {
            var socios = _sociosrepositorio.BuscarSocios();
            return View(socios);
        }
    }
}
