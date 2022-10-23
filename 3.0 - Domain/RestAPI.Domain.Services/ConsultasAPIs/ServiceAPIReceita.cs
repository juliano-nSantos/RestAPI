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
    public class ServiceAPIReceita : IServiceAPIReceita
    {
        private readonly IConsultaAPIReceita _consultaAPIReceita;
        private readonly IValidacoes _validacoes;

        public ServiceAPIReceita(IConsultaAPIReceita consultaAPIReceita,
                                 IValidacoes validacoes)
        {
            _consultaAPIReceita = consultaAPIReceita;
            _validacoes = validacoes;
        }

        public async Task<PessoaJuridica> BuscaDadosPJ(string cnpj)
        {
            string newCnpj = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(cnpj))
                    newCnpj = cnpj.RemovePontosTracosBarras();

                if(_validacoes.ValidaCNPJ(newCnpj))
                    return await _consultaAPIReceita.BuscaDadosPJ(newCnpj);

                return new PessoaJuridica();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
