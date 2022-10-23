using RestAPI.Application.DTO.DTO;
using RestAPI.Domain.Models;
using RestAPI.Infrastruture.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Infrastruture.CrossCutting.Adapter.Map
{
    public class MapperCliente : IMapperCliente
    {
        List<ClienteDTO> clienteDTOs = new List<ClienteDTO>();

        public Cliente MapperToEntity(ClienteDTO clienteDTO)
        {
            var cliente = new Cliente
            {
                Id = clienteDTO.Id,
                Nome = clienteDTO.Nome,
                Sobrenome = clienteDTO.Sobrenome,
                Email = clienteDTO.Email
            };

            return cliente;
        }

        public IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes)
        {
            foreach (var item in clientes)
            {
                clienteDTOs.Add(new ClienteDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Sobrenome = item.Sobrenome,
                    Email = item.Email
                });
            }

            return clienteDTOs;
        }

        public ClienteDTO MapperToDTO(Cliente cliente)
        {
            var clienteDTO = new ClienteDTO
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };

            return clienteDTO;
        }

        
    }
}
