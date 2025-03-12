using Microsoft.AspNetCore.Mvc;

namespace TarakanSIMRS.Helper
{
    public static class ControllerHelper
    {
        public static string MakeActiveClass(this IUrlHelper urlHelper, string controller, string action)
        {
            try
            {
                string controllerName = urlHelper.ActionContext.RouteData.Values["controller"].ToString();
                string methodName = urlHelper.ActionContext.RouteData.Values["action"].ToString();
                if (string.IsNullOrEmpty(controllerName) || string.IsNullOrEmpty(methodName))
                    return string.Empty;

                if (controllerName.Equals(controller) && methodName.Equals(action))
                    return "active";

                return string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
