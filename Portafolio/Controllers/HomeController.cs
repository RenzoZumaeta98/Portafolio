using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
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
            var persona = new Persona()
            {
                Nombre = "Renzo Zumaeta",
                Edad = 26
            };
            ViewBag.Nombre = "Renzo Zumaeta Pisango";
            ViewBag.Edad = 25;

            return View(persona); //Si esta vacio, busca la vista con el nombre de la funcion ("Index()")
                            //Si se quiere buscar otra vista, colocar View("NombreDeVista")
            
        }

        public IActionResult Privacy()
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
