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
    public class ApplicationServiceAPIReceita : IApplicationServiceAPIReceita
    {
        private readonly IServiceAPIReceita _serviceAPIReceita;
        private readonly IMapperAPIReceita _mapperAPIReceita;

        public ApplicationServiceAPIReceita(IServiceAPIReceita serviceAPIReceita,
                                            IMapperAPIReceita mapperAPIReceita)
        {
            _serviceAPIReceita = serviceAPIReceita;
            _mapperAPIReceita = mapperAPIReceita;
        }

        public async Task<PessoaJuridicaDTO> BuscaDadosPJ(string cnpj)
        {
            var pessoaJuricaDTO = new PessoaJuridicaDTO();
            try
            {
                var pessoaJuridica = await _serviceAPIReceita.BuscaDadosPJ(cnpj);

                if (pessoaJuridica != null)
                    pessoaJuricaDTO = _mapperAPIReceita.MapperToDTO(pessoaJuridica);


                return pessoaJuricaDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
