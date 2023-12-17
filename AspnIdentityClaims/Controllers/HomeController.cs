using AspnIdentityClaims.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspnIdentityClaims.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;
        public HomeController(UserManager<AppUser> userMgr, SignInManager<AppUser> signMgr)
        {
            signInManager = signMgr;
            userManager = userMgr;
        }

        //[Authorize]
        public async Task<IActionResult> Index()
        {
            string message = "";
            AppUser user = await userManager.GetUserAsync(HttpContext.User);

            if (user != null)
            {
                message = "Hello " + user.UserName;
            }
            return View((object)message);
        }
    }
}
