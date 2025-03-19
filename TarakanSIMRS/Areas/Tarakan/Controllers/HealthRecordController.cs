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
        private readonly IServiceUnit _serviceUnit;
        private readonly IAppUser _appUser;
        public HealthRecordController(IRegistration registration, IParamedic paramedic, IAppStandardReferenceItem appStandardReferenceItem, IServiceUnit serviceUnit, IConfiguration config, IAppProgram appProgram,
            IAppParameter appParameter, IAppUser appUser) : base(config, appProgram, registration, appParameter, appStandardReferenceItem)
        {
            _paramedic = paramedic;
            _serviceUnit = serviceUnit;
            _appUser = appUser;
        }

        public IActionResult HealthRecord()
        {
            var au = _appUser.AppUserLoad(baseCustom.UserID);
            var model = new HealthRecordViewModel
            {
                getRegistration = _registration.RegistrationEmr(new RegistrationFilter
                {
                    ParamedicID = !string.IsNullOrEmpty(baseCustom.ParamedicID) ? baseCustom.ParamedicID : string.Empty,
                    ServiceUnitID = !string.IsNullOrEmpty(au.au.ParamedicId) && !string.IsNullOrEmpty(au.au.ServiceUnitId) && au.au.SruserType == Const.Doctor ? au.au.ServiceUnitId : string.Empty,
                    IsIncludeClosed = false,
                    IsIncludeDischarge = false,
                    IsIncludeIPRSOAPInputted = false,
                    IsIncludeNonIPRSOAPInputted = false,
                    RegistrationDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                    ExamOrderFromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(-1).Day),
                    ExamOrderToDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
                }, baseCustom.UserID),
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
            model.IsDropDownEnabled = !string.IsNullOrEmpty(baseCustom.ParamedicID) && baseCustom.Role == Const.Doctor;

            if (!string.IsNullOrEmpty(baseCustom.ParamedicID) && baseCustom.Role == Const.Doctor)
                model.getParamedic ??= [new() { ParamedicID = baseCustom.ParamedicID, ParamedicName = _paramedic.GetParamedicName(baseCustom.ParamedicID) }];
            else
            {
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
                var unit = _serviceUnit.GetServiceUnit(baseCustom.UserID, string.Empty, true);
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
                    ParamedicID = !string.IsNullOrEmpty(baseCustom.ParamedicID) ? baseCustom.ParamedicID : model.ParamedicID,
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
                }, baseCustom.UserID)
            };

            return View("HealthRecord", filter);
        }
        #endregion
    }
}
