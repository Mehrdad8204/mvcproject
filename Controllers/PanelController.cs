using Microsoft.AspNetCore.Mvc;

namespace mvcproject.Controllers
{
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}