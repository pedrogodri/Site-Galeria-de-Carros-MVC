using Microsoft.AspNetCore.Mvc;

namespace Galeria.Carros.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
