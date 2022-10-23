using RestAPI.Application.DTO.DTO;
using RestAPI.Application.Interfaces;
using RestAPI.Domain.Core.Interfaces.Services;
using RestAPI.Infrastruture.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Application.Service
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            _serviceCliente = serviceCliente;
            _mapperCliente = mapperCliente;
        }

        public void Add(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceCliente.Add(objCliente);
            
        }

        public void Dispose()
        {
            _serviceCliente.Dispose();
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var objClientes = _serviceCliente.GetAll();
            return _mapperCliente.MapperListClientes(objClientes);
        }

        public ClienteDTO GetById(int id)
        {
            var objCliente = _serviceCliente.GetById(id);
            return _mapperCliente.MapperToDTO(objCliente);
        }

        public void Remove(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceCliente.Remove(objCliente);
        }

        public void Update(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceCliente.Update(objCliente);
        }
    }
}
