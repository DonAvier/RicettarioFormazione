using Microsoft.AspNetCore.Mvc;
using Ricettario.Web.MVC.Models;
using Ricettario.Web.MVC.Services;

namespace Ricettario.Web.MVC.Controllers
{
    public class RecepitController : Controller
    {
        private Ricetta ricetta;
        public RecepitController(Ricetta _ricetta)
        {
            ricetta = _ricetta;
        }

        [HttpGet]
        public IActionResult CreateRecepit()
        {
            return View();
        }

    }
}
