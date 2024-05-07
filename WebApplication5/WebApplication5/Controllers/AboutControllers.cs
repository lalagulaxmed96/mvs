using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class AboutControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
