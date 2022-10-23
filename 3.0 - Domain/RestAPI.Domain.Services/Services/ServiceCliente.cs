using RestAPI.Domain.Core.Interfaces.Repositorys;
using RestAPI.Domain.Core.Interfaces.Services;
using RestAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Domain.Services.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente _repositoryCliente;
        public ServiceCliente(IRepositoryCliente repositoryCliente)
            : base(repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }
    }
}
