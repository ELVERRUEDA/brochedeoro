using Microsoft.AspNetCore.Mvc;

namespace SistemBroche.AplicacionWeb.Controllers
{
    public class LugaresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
