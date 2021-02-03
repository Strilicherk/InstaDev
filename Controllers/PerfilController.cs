using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}