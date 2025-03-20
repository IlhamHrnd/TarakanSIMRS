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
            if (au.au == null || string.IsNullOrEmpty(au.au.UserName))
            {
                ModelState.AddModelError("Failed", "User Not Found");
                return View(model);
            }

            var claims = new List<Claim>
            {
                new Claim("UserID", au.au.UserId),
                new Claim("Username", au.au.UserName),
                new Claim("Expired", au.au.ExpireDate.ToString(Const.Date)),
                new Claim("ParamedicID", au.au.ParamedicId ?? string.Empty),
                new Claim("ServiceUnitID", au.au.ServiceUnitId ?? string.Empty),
                new Claim("PersonID", au.au.PersonId == 0 || au.au.PersonId == null ? string.Empty : au.au.PersonId.ToString()),
                new Claim("Role", au.au.SruserType ?? string.Empty)
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
