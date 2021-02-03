using System;
using InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    public class PostController : Controller
    {

        Post postModel = new Post();

        public IActionResult feed(){
            
            //Listando todas as Publicações e enviando-as pra view 
            ViewBag.Pubs = postModel.ReadAll();
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form ){
            
            Post novoPost = new Post();

            //Resolver dps problema com id, por enquanto tentar enquanto der

            //input de cadastro de Idimagem que não era pra existir
            novoPost.idImagem =Int32.Parse( form["idImagem"] );

            //input da legenda que é o unico que tem
            novoPost.legenda = form["legenda"];

            //botão envviar imagem    
            novoPost.imagem = form["imagem"];

            //Chamamos o metodo Create para salvar as informações do Usuario no CSV
            postModel.Create(novoPost);
            ViewBag.Pubs = postModel.ReadAll();

            return LocalRedirect("~/Post");
        }
    }
}