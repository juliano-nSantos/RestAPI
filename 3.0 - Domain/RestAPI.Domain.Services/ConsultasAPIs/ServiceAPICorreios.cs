using RestAPI.Domain.Core.Interfaces.Repositorys;
using RestAPI.Domain.Core.Interfaces.Services;
using RestAPI.Domain.Core.Interfaces.Validacoes;
using RestAPI.Domain.Models;
using RestAPI.Domain.Services.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Domain.Services.ConsultasAPIs
{
    public class ServiceAPICorreios : IServiceAPICorreios
    {
        private readonly IConsultaAPICorreios _consultaAPICorreios;
        private readonly IValidacoes _validacoes;

        public ServiceAPICorreios(IConsultaAPICorreios consultaAPICorreios,
                                  IValidacoes validacoes)
        {
            _consultaAPICorreios = consultaAPICorreios;
            _validacoes = validacoes;
        }

        public async Task<Enderecos> BuscaDadosPorCep(string cep)
        {
            string newCep = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(cep))
                    newCep = cep.RemovePontosTracosBarras(); //.Replace(".", "").Replace("-", "");

                if (_validacoes.ValidaCep(newCep))
                    return await _consultaAPICorreios.BuscaDadosPorCep(newCep);

                return new Enderecos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
