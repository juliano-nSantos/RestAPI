using Newtonsoft.Json;
using RestAPI.Domain.Core.Interfaces.Repositorys;
using RestAPI.Domain.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Infraestructure.Repository.ConsultasAPIs
{
    public class ConsultaAPIReceita : IConsultaAPIReceita
    {
        private RestClient client;

        public async Task<PessoaJuridica> BuscaDadosPJ(string cnpj)
        {
            try
            {
                client = new RestClient(string.Format("https://www.receitaws.com.br/v1/cnpj/" + cnpj));
                var request = new RestRequest("", Method.Get);

                request.AddHeader("dataType", "jsonp");
                request.AddHeader("Content-Type", "text/javascript");

                client.Options.MaxTimeout = 300000;
                var response = Task.Run(() => client.Execute(request));

                response.Wait();

                if (response.Result.StatusCode == HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<PessoaJuridica>(response.Result.Content);
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }                      
        }
    }
}
