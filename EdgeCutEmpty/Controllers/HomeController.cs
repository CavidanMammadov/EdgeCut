using Microsoft.AspNetCore.Mvc;

namespace EdgeCutEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Furniture()
        {
            return View();
        }
        public IActionResult Blogs()
        {
            return View();
        }
    }
}
