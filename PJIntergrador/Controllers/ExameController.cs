using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PJIntergrador.Data.Repositorio.Interfaces;
using PJIntergrador.Models;

namespace PJIntergrador.Controllers
{
    public class ExameController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
