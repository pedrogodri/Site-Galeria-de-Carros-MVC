using Galeria.Carros.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Galeria.Carros.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("home/privacy")]
        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("home/contato")]
        [Route("contato")]
        public IActionResult Contato()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}