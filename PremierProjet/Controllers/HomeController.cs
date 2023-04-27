using Microsoft.AspNetCore.Mvc;

namespace PremierProjet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            
            return View();
        }

        public IActionResult Page2(int id)
        {
            
            return View();
        }
    }
}
