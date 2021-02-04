using System;
using System.IO;
using InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    [Route("Feed")]

    public class PostController : Controller
    {
        
       
        Post postModel = new Post();

        public IActionResult Index(){
            
            //Listando todas as Publicações e enviando-as pra view 
            ViewBag.Pubs = postModel.ReadAll();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form ){
            
            Post novoPost = new Post();

            //Resolver dps problema com id, por enquanto tentar enquanto der

            //input de cadastro de Idimagem que não era pra existir
            novoPost.idImagem =Int32.Parse( form["idImagem"] );

            //input da legenda que é o unico que tem
            novoPost.legenda = form["legenda"];

            //Inicio uploud

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/fotopub" );
                
                //Verificamos se a pasta não e existe, e se não criamos
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
 
                using (var stream = new FileStream(path, FileMode.Create ))
                {
                    file.CopyTo(stream);
                }


                novoPost.imagem = file.FileName;

            }
            else{
                novoPost.imagem = "padrão.png";
            }
            

            //Chamamos o metodo Create para salvar as informações do Usuario no CSV
            postModel.Create(novoPost);
            ViewBag.Pubs = postModel.ReadAll();

            return LocalRedirect("~/Post/Cadastrar");
        }
    }
}