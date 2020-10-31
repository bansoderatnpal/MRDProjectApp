using MyGitProj.ServiceLayer;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace MyGitProj
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<_IAllRepositoryBusinessLogic>(new InjectionConstructor(0));
            container.RegisterType<IAllRepository, _IAllRepositoryBusinessLogic>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}