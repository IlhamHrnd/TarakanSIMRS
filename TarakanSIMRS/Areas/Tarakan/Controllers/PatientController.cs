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
        private readonly IPatient _patient;
        private readonly IRegistrationPathway _registrationPathway;
        private readonly IMergeBilling _mergeBilling;
        private readonly IEpisodeDiagnose _episodeDiagnose;
        private readonly IVitalSign _vitalSign;
        public PatientController(IConfiguration config, IRegistration registration, IPatient patient, IRegistrationPathway registrationPathway,
            IMergeBilling mergeBilling, IEpisodeDiagnose episodeDiagnose, IVitalSign vitalSign, IAppProgram appProgram) : base(config, appProgram, registration)
        {
            _patient = patient;
            _registrationPathway = registrationPathway;
            _mergeBilling = mergeBilling;
            _episodeDiagnose = episodeDiagnose;
            _vitalSign = vitalSign;
        }

        [HttpGet]
        public IActionResult PatientInfo()
        {
            var model = new PatientInfoViewModel
            {
                getRegistration = _registration.LoadByPrimaryKey(RegNo)
            };

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult PatientChronic()
        {
            var model = new PatientChronicViewModel
            {
                getPatientChronic = _patient.PatientChronic(PatId)
            };

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult PatientRiskStatus()
        {
            var reg = _registration.LoadByPrimaryKey(RegNo);
            var model = new PatientRiskStatusViewModel
            {
                getRiskStatus = _patient.PatientRisk(reg.SRPatientRiskStatus)
            };

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult PatientPathway()
        {
            var model = new PatientPathwayViewModel
            {
                getPatientPathway = _registrationPathway.GetRegistrationPathwayName(RegNo)
            };

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult PatientBilling(bool isModeText)
        {
            var model = new PatientBillingViewModel
            {
                getPatientBilling = _mergeBilling.PlafondProgress(RegNo, isModeText)
            };

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult PatientAllergy()
        {
            var model = new PatientAllergyViewModel
            {
                getPatientAllergy = _patient.PatientAllergy(PatId)
            };

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult PatientDiagnoseSummary()
        {
            var model = new PatientDiagnoseSummary
            {
                getPatientDiagnoses = _episodeDiagnose.DiagnoseSummary(RegNo)
            };

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult PatientVitalSign()
        {
            var reg = _registration.LoadByPrimaryKey(RegNo);
            var model = new PatientVitalSignViewModel
            {
                getLastVitalSign = _vitalSign.VitalSignLastValue(reg.RegistrationNo, reg.FromRegistrationNo, false, DateTime.Now)
            };

            return PartialView(model);
        }
    }
}
