﻿using RestAPI.Domain.Core.Interfaces.Repositorys;
using RestAPI.Domain.Core.Interfaces.Services;
using RestAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Domain.Services.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto)
            : base(repositoryProduto)
        {
            _repositoryProduto = repositoryProduto;
        }
    }
}
