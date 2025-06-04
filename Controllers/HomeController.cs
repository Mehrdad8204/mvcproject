using Microsoft.AspNetCore.Mvc;

namespace mvcproject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Category(int id)
        {
            return View();
        }

        public IActionResult Show(int id)
        {
            return View();
        }
    }
}