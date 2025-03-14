﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using TarakanSIMRS.Areas.Tarakan.Models;

namespace TarakanSIMRS.Areas.Tarakan.Controllers
{
    public class BaseController : Controller
    {
        private readonly IAppProgram _appProgram;
        protected readonly IConfiguration _config;
        protected readonly IRegistration _registration;
        protected readonly IAppParameter _appParameter;
        protected readonly IAppStandardReferenceItem _appStandardReferenceItem;
        public BaseController(IConfiguration config, IAppProgram appProgram, IRegistration registration, IAppParameter appParameter, IAppStandardReferenceItem appStandardReferenceItem)
        {
            _config = config;
            _appProgram = appProgram;
            _registration = registration;
            _appParameter = appParameter;
            _appStandardReferenceItem = appStandardReferenceItem;
        }

        //Variabel
        protected int Page { get; set; }
        protected int PageSize { get; set; }
        protected string RegType { get; set; }
        protected string RegNo { get; set; }
        protected string ParId { get; set; }
        protected string SuId { get; set; }
        protected string RoomId { get; set; }
        protected string PatId { get; set; }
        protected bool IsDoctorDuty { get; set; }
        protected BaseModel baseModel { get; set; }
        protected bool IsLoadBillingProgress { get; set; }
        protected bool IsLoginDoctor { get; set; }
        protected AppProgramDto baseAppProgram { get; set; }
        protected bool IsUserVisible { get; set; }
        protected List<string> MergeRegistration { get; set; }
        protected void SetSessionData<T>(string key, T data)
        {
            HttpContext.Session.SetString(key, JsonConvert.SerializeObject(data));
        }

        protected T? GetSessionData<T>(string key)
        {
            var value = HttpContext.Session.GetString(key);
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            
            //Query String
            Page = !string.IsNullOrEmpty(Request.Query["currentPage"]) ? Converter.StringToInt(Request.Query["currentPage"]) : 1;
            PageSize = !string.IsNullOrEmpty(Request.Query["pageSize"]) ? Converter.StringToInt(Request.Query["pageSize"]) : 1;
            IsDoctorDuty = Request.Query["isDocDuty"] == "True" || Request.Query["isDocDuty"] == "Yes";
            string? programId = Request.Query.ContainsKey("pgId") && !string.IsNullOrEmpty(Request.Query["pgId"]) ? Request.Query["pgId"].ToString() : ViewData["pgId"]?.ToString();

            //View Bag
            ViewData["currentPage"] = Page;
            ViewData["pageSize"] = PageSize;
            ViewData["isDoctorDuty"] = PageSize;
            ViewData["pgId"] = programId;

            //Save Session
            if (!string.IsNullOrEmpty(Request.Query["RegNo"]))
                SetSessionData<string>("RegNo", Request.Query["RegNo"]);

            if (!string.IsNullOrEmpty(Request.Query["regType"]))
                SetSessionData<string>("RegType", Request.Query["regType"]);

            if (!string.IsNullOrEmpty(Request.Query["parId"]))
                SetSessionData<string>("ParId", Request.Query["parId"]);

            if (!string.IsNullOrEmpty(Request.Query["suId"]))
                SetSessionData<string>("SuId", Request.Query["suId"]);

            if (!string.IsNullOrEmpty(Request.Query["RoomId"]))
                SetSessionData<string>("RoomId", Request.Query["RoomId"]);

            if (!string.IsNullOrEmpty(Request.Query["patId"]))
                SetSessionData<string>("PatId", Request.Query["patId"]);

            //Retrieve Session
            RegNo = GetSessionData<string>("RegNo");
            RegType = GetSessionData<string>("RegType");
            ParId = GetSessionData<string>("ParId");
            SuId = GetSessionData<string>("SuId");
            RoomId = GetSessionData<string>("RoomId");
            PatId = GetSessionData<string>("PatId");

            //User
            if (User.Identity.IsAuthenticated)
            {
                var model = GetSessionData<BaseModel>("BaseModel");
                if (model == null)
                    SetSessionData("BaseModel", baseModel = new BaseModel
                    {
                        UserID = User.Claims.FirstOrDefault(c => c.Type == "UserID")?.Value,
                        Username = User.Claims.FirstOrDefault(c => c.Type == "Username")?.Value,
                        ParamedicID = User.Claims.FirstOrDefault(c => c.Type == "ParamedicID")?.Value,
                        ServiceUnitID = User.Claims.FirstOrDefault(c => c.Type == "ServiceUnitID")?.Value,
                        PersonID = User.Claims.FirstOrDefault(c => c.Type == "PersonID")?.Value,
                        Role = User.Claims.FirstOrDefault(c => c.Type == "Role")?.Value
                    });
                else
                {
                    baseModel = model;
                    ViewData["UserId"] = model.UserID;
                    ViewData["UserParId"] = model.ParamedicID;
                    ViewData["UserRole"] = model.Role;
                }
            }

            //Condition
            IsLoadBillingProgress = _config["Tarakan:IsLoadBillingProgress"].ToLower() == "true" || _config["Tarakan:IsLoadBillingProgress"].ToLower() == "yes";
            IsLoginDoctor = baseModel.Role == Const.Doctor && !string.IsNullOrEmpty(baseModel.ParamedicID);

            //Load Program
            baseAppProgram = _appProgram.LoadAppProgram(programId);
            if (baseAppProgram != null && !string.IsNullOrEmpty(baseAppProgram.ProgramName))
                ViewData["Title"] = baseAppProgram.ProgramName;

            IsUserVisible = _appProgram.IsUserProgramAllow(baseModel.UserID, programId);
            if (!string.IsNullOrEmpty(RegNo))
                MergeRegistration = _registration.MergeRegistration(RegNo);
        }
    }
}
