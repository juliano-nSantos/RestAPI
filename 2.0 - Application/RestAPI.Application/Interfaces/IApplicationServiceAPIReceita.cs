using RestAPI.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Application.Interfaces
{
    public interface IApplicationServiceAPIReceita
    {
        Task<PessoaJuridicaDTO> BuscaDadosPJ(string cnpj);
    }
}
