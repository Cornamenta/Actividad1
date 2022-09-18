using Microsoft.AspNetCore.Mvc;
using U1Act1.Models;

namespace U1Act1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MiPerfil(PerfilViewModel perfil)
        {
            return View(perfil);
        }
    }
}
