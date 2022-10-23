using RestAPI.Application.DTO.DTO;
using RestAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperAPIReceita
    {
        PessoaJuridicaDTO MapperToDTO(PessoaJuridica pessoaJuridica);
    }
}
