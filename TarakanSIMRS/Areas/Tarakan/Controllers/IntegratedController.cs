using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tarakan.BusinessObjects.Interface;
using TarakanSIMRS.Areas.Tarakan.Models.Integrated;

namespace TarakanSIMRS.Areas.Tarakan.Controllers
{
    [Area("Tarakan")]
    [Authorize]
    public class IntegratedController : BaseController
    {
        private readonly IRegistrationInfoMedic _registrationInfoMedic;
        private readonly IParamedic _paramedic;
        public IntegratedController(IConfiguration config, IRegistration registration, IAppProgram appProgram, IAppParameter appParameter, IAppStandardReferenceItem appStandardReferenceItem, IRegistrationInfoMedic registrationInfoMedic, IParamedic paramedic) : base(config, appProgram, registration, appParameter, appStandardReferenceItem)
        {
            _registrationInfoMedic = registrationInfoMedic;
            _paramedic = paramedic;
        }

        [HttpGet]
        public IActionResult IntegratedNote()
        {
            var model = new IntegratedNoteViewModel
            {
                getIntegratedNote = _registrationInfoMedic.IntegratedNotes(RegType, RegNo, MergeRegistration, PatId, string.Empty, baseCustom.UserID),
                isUserParamedicDpjp = _paramedic.IsUserParamedicDpjp(baseCustom.ParamedicID, RegNo, DateTime.Now)
            };

            return PartialView(model);
        }
    }
}