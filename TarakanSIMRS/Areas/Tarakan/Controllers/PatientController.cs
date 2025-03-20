using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tarakan.BusinessObjects.Dto;
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
            IMergeBilling mergeBilling, IEpisodeDiagnose episodeDiagnose, IVitalSign vitalSign, IAppProgram appProgram, IAppParameter appParameter,
            IAppStandardReferenceItem appStandardReferenceItem) : base(config, appProgram, registration, appParameter, appStandardReferenceItem)
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

        [HttpGet]
        public async Task<IActionResult> PatientSchedule()
        {
            var model = new PatientSchedulingViewModel();

            model.getScheduleType ??= [
                new() { ItemName = "Day", ItemID = "day"},
                new() { ItemName = "Month", ItemID = "month"},
                new() { ItemName = "Year", ItemID = "year" }];

            model.getYear ??= [
                new() { ItemName = DateTime.Now.Year.ToString(), ItemID = DateTime.Now.Year.ToString()},
                new() { ItemName = DateTime.Now.AddYears(1).Year.ToString(), ItemID = DateTime.Now.AddYears(1).Year.ToString()},
                new() { ItemName = DateTime.Now.AddYears(2).Year.ToString(), ItemID = DateTime.Now.AddYears(2).Year.ToString()}];

            model.getMonth ??= [
                new() { ItemName = "January", ItemID = "1"},
                new() { ItemName = "February", ItemID = "2"},
                new() { ItemName = "March", ItemID = "3"},
                new() { ItemName = "April", ItemID = "4"},
                new() { ItemName = "May", ItemID = "5"},
                new() { ItemName = "June", ItemID = "6"},
                new() { ItemName = "July", ItemID = "7"},
                new() { ItemName = "August", ItemID = "8"},
                new() { ItemName = "September", ItemID = "9"},
                new() { ItemName = "October", ItemID = "10"},
                new() { ItemName = "November", ItemID = "11"},
                new() { ItemName = "December", ItemID = "12"}];

            model.getScheduleName ??= [new() { ItemID = string.Empty, ItemName = string.Empty }];
            if (model.getScheduleName.Count > 0)
            {
                var asri = await _appStandardReferenceItem.GetReferenceItem("PatientScheduleName", true, false);
                if (asri.Count > 0)
                {
                    foreach (var item in asri)
                    {
                        var items = new AppStandardReferenceItemDto
                        {
                            StandardReferenceID = item.StandardReferenceID,
                            ItemID = item.ItemID,
                            ItemName = item.ItemName
                        };
                        model.getScheduleName.Add(items);
                    }
                }
            }

            return PartialView(model);
        }

        #region Process
        [HttpGet]
        public IActionResult AddSchedule(string itemId, string type, int year, int month, DateTime from, DateTime to)
        {
            return Json(_patient.PatientAddSchedule(itemId, type, year, month, from, to, PatId, ParId, SuId, baseCustom.UserID));
        }
        #endregion
    }
}
