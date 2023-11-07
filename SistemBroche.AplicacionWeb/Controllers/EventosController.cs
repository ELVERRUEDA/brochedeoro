using Microsoft.AspNetCore.Mvc;

namespace SistemBroche.AplicacionWeb.Controllers
{
    public class EventosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
