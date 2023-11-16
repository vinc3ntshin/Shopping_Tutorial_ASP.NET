using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Shopping_Tutor.Models;
using Shopping_Tutor.Repository;
using System.Security.Claims;

namespace Shopping_Tutor.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly DataContext _dataContext;
        public CheckoutController(DataContext context)
        {
            _dataContext = context;
        }

        public async Task<IActionResult> Checkout()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);
            if (userEmail == null)
            {
                return RedirectToAction("Login","Account");
            }
            else
            {
                var odercode = Guid.NewGuid().ToString();
                var oderItem = new OrderModel();
                oderItem.OrderCode = odercode;
                oderItem.UserName = userEmail;
                oderItem.Status = 1;
                _dataContext.Add(oderItem);
                _dataContext.SaveChanges();
                TempData["success"] = "Đơn hàng đã được tạo";
                return RedirectToAction("Index","Cart");
            }
            return View();
        }
    }
}
