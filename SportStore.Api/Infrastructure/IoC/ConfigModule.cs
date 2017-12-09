using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using SportStore.Api.Infrastructure.Mapper;
using SportStore.Api.Infrastructure.Security;
using SportStore.Repository.ISportStoreRepo;
using SportStore.Repository.SportStoreRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Api.Infrastructure.IoC
{
    public class ConfigModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StoreContext>().As<IStoreContext>().InstancePerLifetimeScope();
            builder.RegisterInstance(AutoMapperConfig.Initialize()).SingleInstance();
            builder.RegisterModule(new AutofacWebTypesModule());
            base.Load(builder);
        }
    }
}