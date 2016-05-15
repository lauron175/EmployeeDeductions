[assembly: WebActivator.PostApplicationStartMethod(typeof(EmployeeDeductions.Web.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace EmployeeDeductions.Web.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;

    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using Domain.Models;
    using Domain.Interfaces;
    using Domain.Repositories;
    using Domain.Services;
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
            //services
            container.Register<IService<Employee>, EmployeeService>(Lifestyle.Scoped);

            //repositories
            container.Register<IRepository<Employee>, EmployeeRepository>(Lifestyle.Scoped);
        }
    }
}