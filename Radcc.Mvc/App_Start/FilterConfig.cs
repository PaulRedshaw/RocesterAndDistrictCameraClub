using System.Web.Mvc;

namespace Radcc.Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
           //TODO: Uncomment this for Admin authorization
            // filters.Add(new CustomAuthorizeAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
