using QX_Frame.Web.Config;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace QX_Frame.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Start Insert

            new ConfigBootStrap();
            new ClassRegisters();

            //End Start Insert
        }
    }
}
