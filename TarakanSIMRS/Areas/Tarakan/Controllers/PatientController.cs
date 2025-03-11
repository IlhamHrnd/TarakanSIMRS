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
        private readonly IPatient _patient;
        private readonly IRegistrationPathway _registrationPathway;
        private readonly IMergeBilling _mergeBilling;
        private readonly IEpisodeDiagnose _episodeDiagnose;
        private readonly IVitalSign _vitalSign;
        public PatientController(IConfiguration config, IRegistration registration, IPatient patient, IRegistrationPathway registrationPathway,
            IMergeBilling mergeBilling, IEpisodeDiagnose episodeDiagnose, IVitalSign vitalSign) : base(config)
        {
            _registration = registration;
            _patient = patient;
            _registrationPathway = registrationPathway;
            _mergeBilling = mergeBilling;
            _episodeDiagnose = episodeDiagnose;
            _vitalSign = vitalSign;
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

        [HttpGet]
        public IActionResult PatientChronic(string patId)
        {
            if (string.IsNullOrEmpty(patId))
                return BadRequest("Invalid request");

            var model = new PatientChronicViewModel
            {
                getPatientChronic = _patient.PatientChronic(patId)
            };

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult PatientRiskStatus(string srRiskStatus)
        {
            var model = new PatientRiskStatusViewModel
            {
                getRiskStatus = _patient.PatientRisk(srRiskStatus)
            };

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult PatientPathway(string regNo)
        {
            var model = new PatientPathwayViewModel
            {
                getPatientPathway = _registrationPathway.GetRegistrationPathwayName(regNo)
            };

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult PatientBilling(string regNo, bool isModeText)
        {
            var model = new PatientBillingViewModel
            {
                getPatientBilling = _mergeBilling.PlafondProgress(regNo, isModeText)
            };

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult PatientAllergy(string patId)
        {
            var model = new PatientAllergyViewModel
            {
                getPatientAllergy = _patient.PatientAllergy(patId)
            };

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult PatientDiagnoseSummary(string regNo)
        {
            var model = new PatientDiagnoseSummary
            {
                getPatientDiagnoses = _episodeDiagnose.DiagnoseSummary(regNo)
            };

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult PatientVitalSign(string regNo, string fromRegNo)
        {
            var model = new PatientVitalSignViewModel
            {
                getLastVitalSign = _vitalSign.VitalSignLastValue(regNo, fromRegNo, false, DateTime.Now)
            };

            return PartialView(model);
        }
    }
}
