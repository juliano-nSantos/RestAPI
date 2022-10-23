using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Domain.Core.Interfaces.Validacoes
{
    public interface IValidacoes
    {
        bool ValidaCNPJ(string cnpj);
        bool ValidaCep(string cep);
    }
}
