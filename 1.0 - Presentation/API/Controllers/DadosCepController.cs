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
    public class DadosCepController : ControllerBase
    {
        private readonly IApplicationServiceAPICorreios _applicationServiceAPICorreios;

        public DadosCepController(IApplicationServiceAPICorreios applicationServiceAPICorreios)
        {
            _applicationServiceAPICorreios = applicationServiceAPICorreios;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromHeader] string cep)
        {
            try
            {
                var dados = await _applicationServiceAPICorreios.BuscaDadosPorCep(cep);

                return Ok(dados);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
