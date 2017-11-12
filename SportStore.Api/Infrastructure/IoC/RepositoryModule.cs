using Autofac;
using SportStore.Repository.ISportStoreRepo;
using SportStore.Repository.SportStoreRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Api.Infrastructure.IoC
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryRepo>().As<ICategoryRepo>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepo>().As<IProductRepo>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepo>().As<IUserRepo>().InstancePerLifetimeScope();
            builder.RegisterType<OrderRepo>().As<IOrderRepo>().InstancePerLifetimeScope();
            builder.RegisterType<OrderItemRepo>().As<IOrderItemRepo>().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}