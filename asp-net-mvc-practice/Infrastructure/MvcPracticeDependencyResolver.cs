using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;


namespace MvcPractice.Infrastructure
{
    public class MvcPracticeDependencyResolver : IDependencyResolver
    {
        public IUnityContainer _unityContainer;

        public MvcPracticeDependencyResolver(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
            //_unityContainer.AddExtension(new Diagnostic());
        }

        public object GetService(Type serviceType)
        {

            //return _unityContainer.IsRegistered(serviceType)
            //? _unityContainer.Resolve(serviceType)
            //: null;

            try
            {
                return _unityContainer.Resolve(serviceType);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _unityContainer.ResolveAll(serviceType);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}