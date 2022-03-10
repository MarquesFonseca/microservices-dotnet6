using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
