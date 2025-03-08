using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Data;
using System.Security.Claims;
using Tarakan.BusinessObjects.Helper;

namespace TarakanSIMRS.Areas.Tarakan.Controllers
{
    public class BaseController : Controller
    {
        //Variabel
        protected int Page { get; set; }
        protected int PageSize { get; set; }
        protected string RegType { get; set; }
        protected string RegNo { get; set; }
        protected string ParId { get; set; }
        protected string SuId { get; set; }
        protected string RoomId { get; set; }
        protected string PatId { get; set; }

        public BaseController()
        {

        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            //Query String
            Page = !string.IsNullOrEmpty(Request.Query["currentPage"]) ? Converter.StringToInt(Request.Query["currentPage"]) : 1;
            RegType = Request.Query["regType"];
            RegNo = Request.Query["regNo"];
            ParId = Request.Query["parId"];
            SuId = Request.Query["suId"];
            RoomId = Request.Query["roomId"];
            PatId = Request.Query["patId"];

            //View Bag
            ViewData["currentPage"] = Page;
            ViewData["pageSize"] = PageSize;
            ViewData["regType"] = RegType;
            ViewData["regNo"] = RegNo;
            ViewData["parId"] = ParId;
            ViewData["suId"] = SuId;
            ViewData["roomId"] = RoomId;
            ViewData["patId"] = PatId;
        }
    }
}
