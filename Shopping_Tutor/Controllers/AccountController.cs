using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping_Tutor.Models;

namespace Shopping_Tutor.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUserModel> _userManager;
        private SignInManager<AppUserModel> _signInManager;
        public AccountController(SignInManager<AppUserModel> signInManager, UserManager<AppUserModel> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
         
        public async Task<IActionResult> Login()
        {
            return View();
        }
    }
}
