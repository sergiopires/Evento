using AutoMapper;
using BancoEventos.Domain.Mapping;
using BancoEventos.Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace BancoEventos.IoC
{
    public static class Injector
    {

        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();

            var mapperConfig = new MapperConfiguration(config => config.AddProfile<MappingConfiguration>());
            mapperConfig.AssertConfigurationIsValid();

            container.RegisterInstance(mapperConfig.CreateMapper());

            container.RegisterType<DbContext, AplicationContext>(new HierarchicalLifetimeManager());

            //container.RegisterType<IServiceCritica, ServiceCritica>();
            //container.RegisterType<IRepositoryCritica, RepositoryCritica>();

        }

    }
}
