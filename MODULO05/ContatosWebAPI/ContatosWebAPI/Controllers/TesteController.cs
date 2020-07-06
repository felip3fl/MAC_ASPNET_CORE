using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ContatosWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ContatosWebAPI.Controllers
{
    public class TesteController : Controller
    {
        string BaseUrl = "http://localhost:55631";

        public IActionResult Index()
        {
            //criando a lista de contatos
            List<Contato> contatoLista = new List<Contato>();

            //criando uma instancia de HttpClient
            using (HttpClient cliente = new HttpClient())
            {
                //definindo o endereço base
                cliente.BaseAddress = new Uri(BaseUrl);

                //definindo o formato dos dados no request
                MediaTypeWithQualityHeaderValue contentType = new
                    MediaTypeWithQualityHeaderValue("application/json");

                cliente.DefaultRequestHeaders.Accept.Add(contentType);

                HttpResponseMessage response = cliente.GetAsync("/api/contatos").Result;
                if (response.IsSuccessStatusCode)
                {
                    var contatoResponse = response.Content.ReadAsStringAsync().Result;
                    contatoLista = JsonConvert.DeserializeObject<List<Contato>>(contatoResponse);
                }
                return View(contatoLista);
            }
        }
    }
}
