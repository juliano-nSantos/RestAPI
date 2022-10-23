using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Application.DTO.DTO
{
    public class PessoaJuridicaDTO
    {
        public string DataAbertura { get; set; }
        public string Situacao { get; set; }
        public string Tipo { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string PorteEmpresa { get; set; }
        public string NaturezaJuridica { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string DataSituacao { get; set; }
        public string MotivoSituacao { get; set; }
        public string CNPJ { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
        public string Status { get; set; }
        public decimal CapitalSocial { get; set; }        
        public virtual EnderecosDTO Endereco { get; set; }
        
    }
}
