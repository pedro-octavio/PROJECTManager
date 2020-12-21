using Autofac;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection;
using PROJECTManager.Domain.Mappers;
using PROJECTManager.IOC.Configuration;
using System;

namespace PROJECTManager.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterMediatR(AppDomain.CurrentDomain.Load("PROJECTManager.Domain"));

            containerBuilder.RegisterAutoMapper(typeof(MappingProfile).Assembly);

            ValidatorsIOC.Load(containerBuilder);

            RepositoriesIOC.Load(containerBuilder);
        }
    }
}
