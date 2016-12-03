using Microsoft.AspNet.Identity;
using Radcc.Data.Context;
using Radcc.Mvc.App_Start;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Radcc.Mvc
{
    public class MvcApplication : HttpApplication
    {



        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Radcc.Service.Configuration.AutoMapperConfig.Configure();
            //var ninjectConfig = new NinjectConfig();
            //DependencyResolver.SetResolver(ninjectConfig);
            //GlobalConfiguration.Configuration.DependencyResolver = new NinjectResolver(ninjectConfig.Kernel);

            //DependencyResolver.SetResolver(NinjectWeb.Start());

        }
    }
}
