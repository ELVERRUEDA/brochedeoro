﻿using Microsoft.AspNetCore.Mvc;

namespace SistemBroche.AplicacionWeb.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
