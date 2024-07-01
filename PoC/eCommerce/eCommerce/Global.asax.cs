using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace eCommerce
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //IoC will get ready with all the dependency object
            UnityConfig.RegisterTypes(UnityConfig.Container);
        }
        protected void Session_Start()
        {
            Session["Role"] = string.Empty;
        }
        protected void Session_End()
        {
            Session["Role"] = null;
        }
    }
}