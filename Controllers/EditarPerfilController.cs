using System.Collections.Generic;
using InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    [Route("EditarPerfil")]
    public class EditarPerfilController : Controller
    {
        User Editar = new User();
        
        [Route("Editar")]
        public IActionResult Index()
        {
            // ViewBag.User = Editar.BuscarId(int.Parse(HttpContext.Session.GetString("_UserName"))); 
            ViewBag.Editar = Editar.ReadAllItems();
            return View();
        }
        [Route("Registered")]
        public IActionResult Excluir(int id)
        {
            Editar.Delete(id);
            ViewBag.Editar = Editar.ReadAllItems();
            return LocalRedirect ("~/User/Registered");
        }
        public IActionResult EditarPerfil(IFormCollection form)
        {
            User newUser = new User();
            // newUser.IdUser = int.Parse(HttpContext.Session.GetString("_UserName")); 
            newUser.Email = form["Email"];
            newUser.CompleteName = form["NomeCompleto"];
            newUser.UserName = form["NomeUsuario"];
            newUser.Password = form["Senha"];
            Editar.Update(newUser);
            ViewBag.Editar = Editar.ReadAllItems();
            return LocalRedirect("~/Perfil/Index");
        }
    }
}