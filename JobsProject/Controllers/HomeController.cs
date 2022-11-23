using Microsoft.AspNetCore.Mvc;

namespace JobsProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
