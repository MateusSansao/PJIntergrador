using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PJIntergrador.Data.Repositorio.Interfaces;

namespace PJIntergrador.Controllers
{
    public class ExameController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ISociosRepositorio _sociosrepositorio;
        public ExameController(IConfiguration configuration, ISociosRepositorio sociosrepositorio)
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
