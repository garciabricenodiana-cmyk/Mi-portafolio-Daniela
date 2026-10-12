using Microsoft.AspNetCore.Mvc;
using Mi_portafolio_Daniela.Models;

namespace Mi_portafolio_Daniela.Controllers
{
    public class ProyectosController : Controller
    {
        private static readonly List<Proyecto> _proyectos = new()
        {
            new Proyecto { Id = 1, Titulo = "Proyecto 1", Descripcion = "Descripción del proyecto",
                           Imagen = "/img/proyecto1.svg", Tecnologias = "C#, MVC" },
            new Proyecto { Id = 2, Titulo = "Proyecto 2", Descripcion = "Descripción del proyecto",
                           Imagen = "/img/proyecto2.svg", Tecnologias = "HTML, CSS, JavaScript" },
            new Proyecto { Id = 3, Titulo = "Proyecto 3", Descripcion = "Descripción del proyecto",
                           Imagen = "/img/proyecto3.svg", Tecnologias = "Azure DevOps, GitHub" }
        };

        public IActionResult Index() => View(_proyectos);
    }
}