using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tarakan.BusinessObjects.Custom;
using Tarakan.BusinessObjects.Interface;

namespace TarakanSIMRS.Areas.Tarakan.Controllers
{
    [Area("Tarakan")]
    [Authorize]
    public class IndexController : BaseController
    {
        public IndexController(IConfiguration config, IAppProgram appProgram, IRegistration registration, IAppParameter appParameter, IAppStandardReferenceItem appStandardReferenceItem) : base(config, appProgram, registration, appParameter, appStandardReferenceItem)
        {

        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            //Remove Session
            if (GetSessionData<BaseCustom>("BaseCustom") != null)
                RemoveSessionData("BaseCustom");

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}
