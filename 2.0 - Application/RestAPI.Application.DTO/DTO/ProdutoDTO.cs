using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Application.DTO.DTO
{
    public class ProdutoDTO
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
