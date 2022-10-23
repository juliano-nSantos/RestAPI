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
    public class ConsultaAPICorreios : IConsultaAPICorreios
    {
        private RestClient client;

        public async Task<Enderecos> BuscaDadosPorCep(string cep)
        {
            try
            {
                client = new RestClient(string.Format("https://viacep.com.br/ws/" + cep + "/json"));

                var request = new RestRequest("", Method.Get);

                client.Options.MaxTimeout = 300000;
                var response = Task.Run(() => client.Execute(request));

                response.Wait();

                if (response.Result.StatusCode == HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<Enderecos>(response.Result.Content);
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
