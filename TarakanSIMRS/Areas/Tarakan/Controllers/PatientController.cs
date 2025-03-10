using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tarakan.BusinessObjects.Interface;
using TarakanSIMRS.Areas.Tarakan.Models.Patient;

namespace TarakanSIMRS.Areas.Tarakan.Controllers
{
    [Area("Tarakan")]
    [Authorize]
    public class PatientController : BaseController
    {
        private readonly IRegistration _registration;
        public PatientController(IConfiguration config, IRegistration registration) : base(config)
        {
            _registration = registration;
        }

        [HttpGet]
        public IActionResult PatientInfo(string regNo)
        {
            if (string.IsNullOrEmpty(regNo))
                return BadRequest("Invalid request");

            var model = new PatientInfoViewModel
            {
                getRegistration = _registration.LoadByPrimaryKey(regNo)
            };

            return PartialView(model);
        }
    }
}
