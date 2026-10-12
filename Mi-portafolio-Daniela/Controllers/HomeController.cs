using Mi_portafolio_Daniela.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mi_portafolio_Daniela.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            
            var carpeta = Path.Combine(_env.WebRootPath, "img");
            var extensiones = new[] { ".png", ".svg" };

            var galeria = Directory.GetFiles(carpeta)
                .Select(f => Path.GetFileName(f) ?? "")
                .Where(n => extensiones.Contains(Path.GetExtension(n).ToLower()))
                .Where(n => !n.StartsWith("foto-perfil") && !n.StartsWith("diana") && !n.StartsWith("proyecto"))
                .OrderBy(n => n)
                .ToList();

            var perfil = new Perfil
            {
                Nombre = "Diana Daniela García Briceño",
                Profesion = "Estudiante de UNAN-Managua",
                AcercaDe = "Soy estudiante de UNAN-Managua (CUR CARAZO). Me gusta el desarrollo web y estoy en tercer año ,he aprendido diversas tecnologias " +
                "que va de el trayecto como estudiante  " +
                "ASP.NET Core MVC, Git y Azure DevOps.",
                Correo = "diana.garcia24400675@estu.unan.edu.ni",
                Foto = "/img/diana.png",
                Habilidades = new()
                {
                    "C#", "ASP.NET Core MVC", "Git", "GitHub",
                    "Azure DevOps", "HTML", "CSS", "JavaScript"
                },
                Galeria = galeria
            };
            return View(perfil);
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
