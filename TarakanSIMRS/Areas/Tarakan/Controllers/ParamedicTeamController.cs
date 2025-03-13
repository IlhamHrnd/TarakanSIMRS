using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tarakan.BusinessObjects.Interface;
using TarakanSIMRS.Areas.Tarakan.Models.ParamedicTeam;

namespace TarakanSIMRS.Areas.Tarakan.Controllers
{
    [Area("Tarakan")]
    [Authorize]
    public class ParamedicTeamController : BaseController
    {
        private readonly IParamedicTeam _paramedicTeam;

        public ParamedicTeamController(IConfiguration config, IAppProgram appProgram, IRegistration registration, IParamedicTeam paramedicTeam, IAppParameter appParameter,
            IAppStandardReferenceItem appStandardReferenceItem) : base(config, appProgram, registration, appParameter, appStandardReferenceItem)
        {
            _paramedicTeam = paramedicTeam;
        }

        [HttpGet]
        public IActionResult ParamedicTeam()
        {
            var model = new ParamedicTeamViewModel
            {
                getParamedicTeam = _paramedicTeam.GetParamedicTeam(RegNo),
                DpjpStatusId = _appParameter.ParameterString("ParamedicTeamStatusDpjpID")
            };

            return PartialView(model);
        }
    }
}
