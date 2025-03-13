using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tarakan.BusinessObjects.Interface;
using TarakanSIMRS.Areas.Tarakan.Models.Registration;

namespace TarakanSIMRS.Areas.Tarakan.Controllers
{
    [Area("Tarakan")]
    [Authorize]
    public class RegistrationController : BaseController
    {
        private readonly IServiceUnit _serviceUnit;
        private readonly IParamedic _paramedic;
        public RegistrationController(IConfiguration config, IAppProgram appProgram, IRegistration registration, IAppParameter appParameter, IAppStandardReferenceItem appStandardReferenceItem, 
            IServiceUnit serviceUnit, IParamedic paramedic) : base(config, appProgram, registration, appParameter, appStandardReferenceItem)
        {
            _serviceUnit = serviceUnit;
            _paramedic = paramedic;
        }

        [HttpGet]
        public IActionResult RegistrationRefer()
        {
            var reg = _registration.LoadByPrimaryKey(RegNo);
            var freg = _registration.LoadByPrimaryKey(reg.FromRegistrationNo);
            var model = new RegistrationReferViewModel
            {
                fromRegistrationNo = freg.RegistrationNo,
                serviceUnitName = _serviceUnit.GetServiceUnitName(freg.ServiceUnitID),
                paramedicName = _paramedic.GetParamedicName(freg.ParamedicID),
            };

            return PartialView(model);
        }
    }
}
