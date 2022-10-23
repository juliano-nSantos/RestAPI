﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Domain.Models
{
    public class Enderecos
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Localidade { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }

    }
}
