using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Application.DTO.DTO
{
    public class EnderecosDTO
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Pais { get; set; }
    }
}
