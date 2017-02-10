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
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Radcc.Service.Configuration.AutoMapperConfig.Configure();
            //var ninjectConfig = new NinjectConfig();
            //DependencyResolver.SetResolver(ninjectConfig);
            // GlobalConfiguration.Configuration.DependencyResolver = new NinjectResolver(ninjectConfig.Kernel);

            //DependencyResolver.SetResolver(NinjectWeb.Start());

        }
    }
}
