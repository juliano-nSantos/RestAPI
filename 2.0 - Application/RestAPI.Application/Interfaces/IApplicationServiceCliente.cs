using RestAPI.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDTO obj);
        ClienteDTO GetById(int id);
        IEnumerable<ClienteDTO> GetAll();
        void Update(ClienteDTO obj);
        void Remove(ClienteDTO obj);
        void Dispose();
    }
}
