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
    public class ApplicationServiceAPICorreios : IApplicationServiceAPICorreios
    {
        private readonly IServiceAPICorreios _serviceAPICorreios;
        private readonly IMapperAPICorreios _mapperAPICorreios;

        public ApplicationServiceAPICorreios(IServiceAPICorreios serviceAPICorreios,
                                             IMapperAPICorreios mapperAPICorreios)
        {
            _serviceAPICorreios = serviceAPICorreios;
            _mapperAPICorreios = mapperAPICorreios;
        }

        public async Task<EnderecosDTO> BuscaDadosPorCep(string cep)
        {
            var enderecoDTO = new EnderecosDTO();

            try
            {
                var endereco = await _serviceAPICorreios.BuscaDadosPorCep(cep);

                if(endereco.Logradouro != null)
                    enderecoDTO = _mapperAPICorreios.MapperToDTO(endereco);

                return enderecoDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
