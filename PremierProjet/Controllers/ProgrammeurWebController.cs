using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace PremierProjet.Controllers
{
    public class ProgrammeurWebController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult E23()
        {
            return View();
        }
        public IActionResult H23()
        {
            return View();
        }
        public IActionResult A22()
        {
            return View();
        }
        public IActionResult E23([FromRoute] string id)
        {
            //switch case
            switch (id)
            {
                case "E23":
                    return Content("Cours1");
                case "H23":
                    return Content(id);
                case "A22":
                    return Content(id);
                default:
                    return Content(id);
            }
            
            
        }
    }
}

