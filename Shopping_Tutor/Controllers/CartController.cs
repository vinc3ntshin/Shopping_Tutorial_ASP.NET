using Microsoft.AspNetCore.Mvc;

namespace Shopping_Tutor.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View("~/Views/Checkout/Index.cshtml");
        }
    }
}
