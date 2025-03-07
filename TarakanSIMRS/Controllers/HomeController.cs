using System.Diagnostics;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using TarakanSIMRS.Models;
using TarakanSIMRS.Models.Home;
using Tarakan.BusinessObjects.Interface;
using Tarakan.BusinessObjects.Helper;

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
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var au = _appUser.LoadByPrimaryKey(model.UserId, SecureTarakan.Encrypt(model.Password, _config["Tarakan:Key01"], _config["Tarakan:Key02"]));
            if (!string.IsNullOrEmpty(au.UserName))
            {
                
            }
            ModelState.AddModelError("", "Invalid email or password.");
            return View(model);
        }
        #endregion
    }
}
