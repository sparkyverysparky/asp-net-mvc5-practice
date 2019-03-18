using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using MvcPractice.Controllers;
using Unity;
using MvcPractice.App_Start;

namespace MvcPractice.Models
{
    public class ControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            try
            {
                if (controllerType == null)
                    throw new ArgumentNullException("controllerType");

                if (!typeof(IController).IsAssignableFrom(controllerType))
                    throw new ArgumentException(string.Format(
                        "Type requested is not a controller: {0}",
                        controllerType.Name),
                        "controllerType");

                return IocConfigurator.Container.Resolve(controllerType) as IController;
            }
            catch
            {
                return null;
            }

        }
    }

}