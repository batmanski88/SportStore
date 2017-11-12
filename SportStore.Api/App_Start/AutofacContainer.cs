using Autofac;
using Autofac.Integration.Mvc;
using SportStore.Api.Infrastructure.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStore.Api.App_Start
{
    public class AutofacContainer
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterAssemblyModules(typeof(MvcApplication).Assembly);
            builder.RegisterModule<RepositoryModule>();
            builder.RegisterModule<ConfigModule>();
            builder.RegisterModule<ServiceModule>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}