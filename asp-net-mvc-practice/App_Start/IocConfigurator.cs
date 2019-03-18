using MvcPractice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using MvcPractice.Infrastructure;
using Unity.Injection;
using System.Web.Mvc;
using Microsoft.Win32;

namespace MvcPractice.App_Start
{
    public class IocConfigurator
    {
        public static IUnityContainer Container { get; set; }

        public static void ConfigureIocUnityConfigurator()
        {
            Container = new UnityContainer();

            RegisterServices(Container);

            MvcPracticeDependencyResolver resolver = new MvcPracticeDependencyResolver(Container);

            DependencyResolver.SetResolver(resolver);
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container
                .RegisterType<IThreadRepository, ThreadRepository>()
                .RegisterType<ICommentRepository, CommentRepository>();
        }
    }
}