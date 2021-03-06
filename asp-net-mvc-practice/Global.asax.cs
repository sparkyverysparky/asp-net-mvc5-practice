﻿using MvcPractice.App_Start;
using MvcPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcPractice
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Issue with Unity IOC container.
            //Since this is not critical to the application, I will comment this out for now.
            //IocConfigurator.ConfigureIocUnityConfigurator();
            //ControllerBuilder.Current.SetControllerFactory(typeof(ControllerFactory));
        }
    }
}
