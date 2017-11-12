﻿using Autofac;
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
            builder.RegisterType<ProductService>().As<ICategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<CartManager>().As<ICartManager>().InstancePerLifetimeScope();
            builder.RegisterType<SessionManager>().As<ISessionManager>().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}