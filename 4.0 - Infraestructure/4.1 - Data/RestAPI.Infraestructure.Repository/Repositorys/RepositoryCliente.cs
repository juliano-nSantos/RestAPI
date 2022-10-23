using RestAPI.Domain.Core.Interfaces.Repositorys;
using RestAPI.Domain.Models;
using RestAPI.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Infraestructure.Repository.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext _context;
        public RepositoryCliente(SqlContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
