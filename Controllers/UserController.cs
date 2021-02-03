using InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    // localhost:5001/Register
    [Route("Register")]
    public class UserController : Controller
    {
        User userModels = new User();

        // localhost:5001/Register
        // [Route("Register")]
        public IActionResult Index(){
            ViewBag.Users = userModels.ReadAllItems();
            return View();
        }

        // localhost:5001/User/New
        [Route("New")]
        public IActionResult Register(IFormCollection registrationForm){ 
            User newUser = new User();
            newUser.Email = registrationForm["Email"];
            newUser.CompleteName = registrationForm["CompleteName"];
            newUser.UserName = registrationForm["UserName"];
            newUser.Password = registrationForm["Password"];

            newUser.IdUser = userModels.IdGenerator();

            userModels.Create(newUser);
            ViewBag.Users = userModels.ReadAllItems();

            // localhost:5001/Instadev/Register
            return LocalRedirect("~/Register");
        }
    }
}