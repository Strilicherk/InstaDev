using InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    // localhost:5001/Instadev
    [Route ("User")]
    public class UserController:Controller
    {
        User userModels = new User();

        // localhost:5001/Instadev/Cadastro
        [Route ("Register")]
        public IActionResult Register(){
            ViewBag.Users = userModels.ReadAllItems();
            return View();
        }

        // localhost:5001/Instadev/Cadastrando
        [Route ("New")]
        public IActionResult Register(IFormCollection registrationForm){ 
            User newUser = new User();
            newUser.Email = registrationForm["Email"];
            newUser.CompleteName = registrationForm["CompleteName"];
            newUser.UserName = registrationForm["UserName"];
            newUser.Password = registrationForm["Password"];

            userModels.Create(newUser);
            ViewBag.Users = userModels.ReadAllItems();

            // localhost:5001/Instadev/Cadastro
            return LocalRedirect("~/User/Register");
        }
    }
}