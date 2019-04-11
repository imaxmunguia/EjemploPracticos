using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace RazorPagesExample.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [BindProperty]
        public Persona persona { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {

        }
        public async Task<ActionResult> OnPost(string idDoc)
        {
            var client = _httpClientFactory.CreateClient();
            
            client.BaseAddress = new Uri("http://localhost:49156/");
            client.DefaultRequestHeaders.Add("ApiKey", "jfoiuewjf982u30fjid08j33232+32e32d3++3323232dsfwefe=");

            var data = new
            {
                codigoTipoIdentificacion = "CEDULA",
                identificacion = "02-0553-0947"
            };

            var result = await client.PostAsync("api/v1.0/Iban/ConsultarPorCliente", data, new JsonMediaTypeFormatter());
            var responseString = await result.Content.ReadAsStringAsync();
            return new JsonResult(new { hola = result });
        }
        public void OnPostPersona()
        {

        }
    }
    public class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
    }
}
