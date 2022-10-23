using RestAPI.Domain.Core.Interfaces.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Domain.Services.Validacoes
{
    public class Validacao : IValidacoes
    {
        public bool ValidaCep(string cep)
        {
            if (string.IsNullOrEmpty(cep))
                return false;            

            if (cep.Length < 8)
                return false;

            if (TodosCaracteresIguais(cep))
                return false;

            return true;
        }

        public bool ValidaCNPJ(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj))
                return false;

            if (cnpj.Length < 14)
                return false;

            if (TodosCaracteresIguais(cnpj))
                return false;

            return true;
        }

        private bool TodosCaracteresIguais(string valor)
        {
            char compare = valor[0];

            return valor.All(v => v.Equals(compare));
        }
    }
}
