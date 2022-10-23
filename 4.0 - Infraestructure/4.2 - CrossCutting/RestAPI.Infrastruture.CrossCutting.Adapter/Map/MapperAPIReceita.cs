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
    public class MapperAPIReceita : IMapperAPIReceita
    {
        public PessoaJuridicaDTO MapperToDTO(PessoaJuridica pj)
        {
            var pessoaJuridicaDTO = new PessoaJuridicaDTO
            {
                DataAbertura = pj.Abertura,
                Situacao = pj.Situacao,
                Tipo = pj.Tipo,
                RazaoSocial = pj.Nome,
                NomeFantasia = pj.Fantasia,
                PorteEmpresa = pj.Porte,
                NaturezaJuridica = pj.Natureza_Juridica,
                Email = pj.Email,
                Telefone = pj.Telefone,
                DataSituacao = pj.Data_Situacao,
                MotivoSituacao = pj.Motivo_Situacao,
                CNPJ = pj.CNPJ,
                UltimaAtualizacao = pj.Ultima_Atualizacao,
                Status = pj.Status,
                CapitalSocial = pj.Capital_Social,
                Endereco = new EnderecosDTO()
                {
                    Bairro = pj.Bairro,
                    Logradouro = pj.Logradouro,
                    Numero = pj.Numero,
                    Complemento = pj.Complemento,
                    Municipio = pj.Municipio,
                    UF = pj.UF,
                    Cep = pj.Cep,
                    Pais = "BR"
                }
            };

            return pessoaJuridicaDTO;
        }
    }
}
