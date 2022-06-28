using Microsoft.AspNetCore.Mvc;

namespace csharp_net_course.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
