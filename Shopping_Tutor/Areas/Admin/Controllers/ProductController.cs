using Microsoft.AspNetCore.Mvc;
using Shopping_Tutor.Repository;

namespace Shopping_Tutor.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly DataContext _dataContext;
        public ProductController(DataContext context)
        {
            _dataContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
