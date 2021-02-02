using System.Collections.Generic;
using InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    public class LoginController : Controller
    {
        
        [TempData]
        public string Mensagem { get; set; }
        User user = new User();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logar(IFormCollection form)
        {
            // Lista todas as linhas do CSV ("banco de dados")
            List<string> csv = user.ReadAllLinesCSV("Database/User.csv");

            // Verifica se o usuário já estiver cadastrado ou logado uma conta
            // ele vai buscar lá no csv
            var logado = 
            csv.Find(
                x => 
                x.Split(";")[0] == form["Email"] && 
                x.Split(";")[3] == form["Password"]
            );


            // se encontrar um usuário, ele irá redirecionar para a página de feed
             if(logado != null)
            {
                HttpContext.Session.SetString("_UserName", logado.Split(";")[0]);
                return LocalRedirect("Feed");
            }

             Mensagem = "Senha ou email incorretos, tente novamente...";
            return LocalRedirect("~/Login");
            }

            [Microsoft.AspNetCore.Mvc.Route("Logout")]
            public IActionResult Logout()
            {
                HttpContext.Session.Remove("_UserName");
                return LocalRedirect("~/");
            }
            }
}