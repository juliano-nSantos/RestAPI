using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadosCnpjController : ControllerBase
    {
        private readonly IApplicationServiceAPIReceita _applicationServiceAPIReceita;

        public DadosCnpjController(IApplicationServiceAPIReceita applicationServiceAPIReceita)
        {
            _applicationServiceAPIReceita = applicationServiceAPIReceita;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromHeader] string cnpj)
        {
            try
            {
                var dados = await _applicationServiceAPIReceita.BuscaDadosPJ(cnpj);

                return Ok(dados);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
