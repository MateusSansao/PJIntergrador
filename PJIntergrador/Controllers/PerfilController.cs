﻿using Microsoft.AspNetCore.Mvc;

namespace PJIntergrador.Controllers
{
    public class PerfilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}