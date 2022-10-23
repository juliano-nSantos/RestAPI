using Autofac;
using RestAPI.Application.Interfaces;
using RestAPI.Application.Service;
using RestAPI.Domain.Core.Interfaces.Repositorys;
using RestAPI.Domain.Core.Interfaces.Services;
using RestAPI.Domain.Core.Interfaces.Validacoes;
using RestAPI.Domain.Services.ConsultasAPIs;
using RestAPI.Domain.Services.Services;
using RestAPI.Domain.Services.Validacoes;
using RestAPI.Infraestructure.Repository.ConsultasAPIs;
using RestAPI.Infraestructure.Repository.Repositorys;
using RestAPI.Infrastruture.CrossCutting.Adapter.Interfaces;
using RestAPI.Infrastruture.CrossCutting.Adapter.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ApplicationServiceAPIReceita>().As<IApplicationServiceAPIReceita>();
            builder.RegisterType<ApplicationServiceAPICorreios>().As<IApplicationServiceAPICorreios>();

            #endregion

            #region IOC Services
            
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<ServiceAPIReceita>().As<IServiceAPIReceita>();
            builder.RegisterType<ServiceAPICorreios>().As<IServiceAPICorreios>();

            #endregion

            #region IOC Repositorys SQL

            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();

            #endregion

            #region IOC Mapper
            
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            builder.RegisterType<MapperAPIReceita>().As<IMapperAPIReceita>();
            builder.RegisterType<MapperAPICorreios>().As<IMapperAPICorreios>();

            #endregion

            #region IOC Consultas APIs

            builder.RegisterType<ConsultaAPIReceita>().As<IConsultaAPIReceita>();
            builder.RegisterType<ConsultaAPICorreios>().As<IConsultaAPICorreios>();

            #endregion

            #region IOC Validacoes

            builder.RegisterType<Validacao>().As<IValidacoes>();

            #endregion

            #endregion
        }
    }
}
