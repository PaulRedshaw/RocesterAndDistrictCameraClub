using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Radcc.Mvc.CustomClasses
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        
        
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var routeData = httpContext.Request.RequestContext.RouteData;
            var controller = routeData.GetRequiredString("controller");
            var action = routeData.GetRequiredString("action");
            var area = routeData.DataTokens["area"];
            var user = httpContext.User;

            if (area != null && area.ToString() == "Admin")
            {
                if (!user.Identity.IsAuthenticated)
                    return false;
                if (!user.IsInRole("Admin"))
                    return false;
            }
            return true;
        }
    }
}