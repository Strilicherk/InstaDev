using System.Collections.Generic;
using InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    [Route("EditarPerfil")]
    public class EdicaoPerfilController : Controller
    {
        User userModel = new User();
        // [Route("Edi")]
        public IActionResult Index()
        {
            // ViewBag.DadosUsuario = userModel.Read
            return View();
        }
        // public IActionResult Excluir(int id)
        // {
        //     userModel.Delete(id);
        //     return LocalRedirect ("~/Register");
        // }
        // public IActionResult Update(User user)
        // {
        //     List<string> linhas = ReadAllLinesCSV (PATH); PATH csv que o cadastro armazena infos
        //     linhas.RemoveAll (y => y.Split (";") [0] == .ToString ());
        //     linhas.Add (Prepare (n));  
        //     RewriteCSV (PATH, linhas); reescrever infos no csv
        // }

    }
}