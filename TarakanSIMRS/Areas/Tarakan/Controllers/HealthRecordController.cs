using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Filter;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using TarakanSIMRS.Areas.Tarakan.Models.HealthRecord;

namespace TarakanSIMRS.Areas.Tarakan.Controllers
{
    [Area("Tarakan")]
    [Authorize]
    public class HealthRecordController : BaseController
    {
        private readonly IParamedic _paramedic;
        private readonly IAppStandardReferenceItem _appStandardReferenceItem;
        private readonly IServiceUnit _serviceUnit;
        public HealthRecordController(IRegistration registration, IParamedic paramedic, IAppStandardReferenceItem appStandardReferenceItem, IServiceUnit serviceUnit,
            IConfiguration config, IAppProgram appProgram) : base(config, appProgram, registration)
        {
            _paramedic = paramedic;
            _appStandardReferenceItem = appStandardReferenceItem;
            _serviceUnit = serviceUnit;
        }

        public IActionResult HealthRecord()
        {
            var model = new HealthRecordViewModel
            {
                getRegistration = _registration.RegistrationEmr(new RegistrationFilter { }, baseModel.UserID),
                IsLoadBillingProgress = IsLoadBillingProgress
            };

            return View(model);
        }

        public IActionResult HealthRecordDetail()
        {
            var model = new HealtRecordDetailViewModel
            {

            };

            return View(model);
        }

        public async Task<IActionResult> FilterHealthRecord()
        {
            var model = new FilterHealthRecordViewModel();

            model.getParamedic ??= [new() { ParamedicID = string.Empty, ParamedicName = string.Empty }];
            if (model.getParamedic.Count > 0)
            {
                var paramedic = await _paramedic.GetParamedic(true);
                if (paramedic.Count > 0)
                {
                    foreach (var item in paramedic)
                    {
                        var par = new ParamedicDto
                        {
                            ParamedicID = item.ParamedicID,
                            ParamedicName = item.ParamedicName
                        };
                        model.getParamedic.Add(par);
                    }
                }
            }

            model.getRegistrationType ??= [new() { ItemName = string.Empty, ItemID = string.Empty }];
            if (model.getRegistrationType.Count > 0)
            {
                var asri = await _appStandardReferenceItem.GetReferenceItem("RegistrationType", true, true);
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
                        model.getRegistrationType.Add(items);
                    }
                }
            }

            model.getServiceUnit ??= [new() { ServiceUnitID = string.Empty, ServiceUnitName = string.Empty }];
            if (model.getServiceUnit.Count > 0)
            {
                var unit = _serviceUnit.GetServiceUnit(baseModel.UserID, string.Empty, true);
                if (unit.Count > 0)
                {
                    foreach (var item in unit)
                    {
                        var su = new ServiceUnitDto
                        {
                            ServiceUnitID = item.ServiceUnitID,
                            ServiceUnitName = item.ServiceUnitName,
                            DepartmentID = item.DepartmentID,
                            ShortName = item.ShortName,
                            SRRegistrationType = item.SRRegistrationType,
                            IsActive = item.IsActive
                        };
                        model.getServiceUnit.Add(su);
                    }
                }
            }

            model.getParamedicTeam ??= 
                [
                    new() { ItemName = "All", ItemID = "all" }, 
                    new() { ItemName = "Patient registered to me", ItemID = "regtome" }
                ];
            if (model.getParamedicTeam.Count > 0)
            {
                var asri = await _appStandardReferenceItem.GetReferenceItem("ParamedicTeamStatus", true, true);
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
                        model.getParamedicTeam.Add(items);
                    }
                }
            }

            model.getConfirmedAttendance ??=
                [
                    new() { ItemName = "All", ItemID = string.Empty},
                    new() { ItemName = "Confirmed", ItemID = "1"},
                    new() { ItemName = "Not Confirm", ItemID = "0"}
                ];

            return PartialView(model);
        }

        #region Process
        [HttpPost]
        public IActionResult FilterHealthRecord(FilterHealthRecordViewModel model)
        {
            var filter = new HealthRecordViewModel
            {
                getRegistration = _registration.RegistrationEmr(new RegistrationFilter
                {
                    RegistrationNo = model.RegistrationNo,
                    ParamedicID = model.ParamedicID,
                    SRRegistrationType = model.SRRegistrationType,
                    ServiceUnitID = model.ServiceUnitID,
                    PatientName = model.PatientName,
                    ParamedicTeam = model.SRParamedicTeam,
                    IsIncludeClosed = model.IsIncludeClosed,
                    IsIncludeDischarge = model.IsIncludeDischarge,
                    IsIncludeIPRSOAPInputted = model.IsIncludeIPRSOAPInputted,
                    IsIncludeNonIPRSOAPInputted = model.IsIncludeNonIPRSOAPInputted,
                    RegistrationDate = model.RegistrationDate,
                    FromRegistrationTime = Converter.DateFormat(model.FromRegistrationTime, Const.Hourmin),
                    ToRegistrationTime = Converter.DateFormat(model.ToRegistrationTime, Const.Hourmin),
                    ConfirmedAttendanceStatus = model.SRConfirmedAttend,
                    ExamOrderFromDate = model.FromExamOrder,
                    ExamOrderToDate = model.ToExamOrder
                }, baseModel.UserID)
            };

            return View("HealthRecord", filter);
        }
        #endregion
    }
}
