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
    public class MapperAPICorreios : IMapperAPICorreios
    {
        public EnderecosDTO MapperToDTO(Enderecos end)
        {
            var enderecoDto = new EnderecosDTO
            {
                Cep = end.Cep,
                Logradouro = end.Logradouro,
                Complemento = end.Complemento,
                Bairro = end.Bairro,
                Municipio = end.Logradouro,
                UF = end.UF,
                Pais = "BR"
            };

            return enderecoDto;
        }
    }
}
