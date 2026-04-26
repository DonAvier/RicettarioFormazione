using Microsoft.AspNetCore.Mvc;
using Ricettario.Web.MVC.Models;
using Ricettario.Web.MVC.Services;

namespace Ricettario.Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        private Auth auth;
        public HomeController(Auth _auth)
        {
            auth = _auth;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if(auth.User != null)
            {
                return RedirectToAction("Profile");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Profile()
        {
            if (auth.User == null)
            {
                return RedirectToAction("Index");
            }
            return View(auth.User);
        }


        [HttpPost]
        public IActionResult Index(UserRequest userRequest) 
        {
            auth.Login(userRequest);
            return RedirectToAction("Profile");
        }
    }
}
