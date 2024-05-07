using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class ContactControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
