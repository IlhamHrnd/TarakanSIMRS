using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using TarakanSIMRS.Models;
using TarakanSIMRS.Models.Home;

namespace TarakanSIMRS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAppUser _appUser;
        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IAppUser appUser, IConfiguration config)
        {
            _logger = logger;
            _appUser = appUser;
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region Process
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var au = _appUser.LoadByPrimaryKey(model.UserId, SecureTarakan.Encrypt(model.Password, _config["Tarakan:Key01"], _config["Tarakan:Key02"]));
            if (string.IsNullOrEmpty(au.UserName))
            {
                ModelState.AddModelError("Failed", "User Not Found");
                return View(model);
            }

            var claims = new List<Claim>
            {
                new Claim("UserID", au.UserId),
                new Claim("Username", au.UserName),
                new Claim("Expired", au.ExpireDate.ToString(Const.Date)),
                new Claim("ParamedicID", au.ParamedicId),
                new Claim("ServiceUnitID", au.ServiceUnitId),
                new Claim("PersonID", au.PersonId is 0 or null ? string.Empty : au.PersonId.ToString()),
                new Claim("Role", au.SruserType)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties
            {
                IsPersistent = true,
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
            string? returnUrl = TempData["ReturnUrl"]?.ToString();
            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            else
                return RedirectToAction("Dashboard", "Index", new { area = "Tarakan" });
        }
        #endregion
    }
}
