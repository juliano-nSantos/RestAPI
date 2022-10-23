using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Domain.Models
{
    public class PessoaJuridica
    {
        public string Abertura { get; set; }
        public string Situacao { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Fantasia { get; set; }
        public string Porte { get; set; }
        public string Natureza_Juridica { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Data_Situacao { get; set; }
        public string Motivo_Situacao { get; set; }
        public string CNPJ { get; set; }
        public DateTime Ultima_Atualizacao { get; set; }
        public string Status { get; set; }
        public decimal Capital_Social { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }


    }
}
