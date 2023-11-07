using Microsoft.AspNetCore.Mvc;

namespace SistemBroche.AplicacionWeb.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Contacto()
        {
            return View();
        }
    }
}
