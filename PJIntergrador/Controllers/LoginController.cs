using Microsoft.AspNetCore.Mvc;
using PJIntergrador.Data.Repositorio.Interfaces;
using PJIntergrador.Models;

namespace PJIntergrador.Controllers
{
    public class LoginController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ISociosRepositorio _sociosRepositorio;


        public LoginController(IConfiguration configuration, ISociosRepositorio sociosRepositorio) 
        {

            _configuration = configuration;
            _sociosRepositorio = sociosRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BuscarLogin(Socios socios)
        {

            try
            {
                var acesso = _sociosRepositorio.ValidarInformacao(socios);

                if (acesso != null)
                {
                    return RedirectToAction("Index", "Home");
                }

                else
                {
                    TempData["MsgErro"] = "Ops algo está errado tente novamente..";
                }
            }

            catch (Exception e)
            {

                TempData["MsgErro"] = "Erro ao buscar dados de banco...";
            }
            return View("Index");
        }
        public IActionResult Experiencia()
        {
            return View();
        }
        public IActionResult SobreNos()
        {
            return View();
        }

    }
}