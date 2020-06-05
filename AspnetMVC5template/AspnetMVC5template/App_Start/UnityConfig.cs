using System.Web.Mvc;
using AspnetMvc5.Core.Interfaces.Facades;
using AspnetMVC5.Infrastructure.Facades;
using Unity;
using Unity.Mvc5;

namespace AspnetMVC5template
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IPersonFacade, PersonFacade>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}