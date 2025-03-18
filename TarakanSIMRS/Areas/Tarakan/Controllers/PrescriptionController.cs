using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tarakan.BusinessObjects.Interface;
using TarakanSIMRS.Areas.Tarakan.Models.Prescription;

namespace TarakanSIMRS.Areas.Tarakan.Controllers
{
    [Area("Tarakan")]
    [Authorize]
    public class PrescriptionController : BaseController
    {
        private readonly ITransPrescription _transPrescription;
        public PrescriptionController(IConfiguration config, IAppProgram appProgram, IRegistration registration, IAppParameter appParameter, IAppStandardReferenceItem appStandardReferenceItem, ITransPrescription transPrescription) : base(config, appProgram, registration, appParameter, appStandardReferenceItem)
        {
            _transPrescription = transPrescription;
        }

        public IActionResult PrescriptionHistory()
        {
            var model = new TransPrescriptionViewModel
            {
                getMedicationHistory = _transPrescription.GetHistoryPrescription(RegistrationNos)
            };

            return PartialView(model);
        }
    }
}
