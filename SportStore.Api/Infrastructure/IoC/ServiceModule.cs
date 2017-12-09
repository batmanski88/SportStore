using Autofac;
using SportStore.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Api.Infrastructure.IoC
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<CartManager>().As<ICartManager>().InstancePerLifetimeScope();
            builder.RegisterType<SessionManager>().As<ISessionManager>().InstancePerLifetimeScope();
            builder.RegisterType<OrderService>().As<IOrderService>().InstancePerLifetimeScope();
            builder.RegisterType<Encrypter>().As<IEncrypter>().InstancePerLifetimeScope();
            builder.RegisterType<AccountService>().As<IAccountService>().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}