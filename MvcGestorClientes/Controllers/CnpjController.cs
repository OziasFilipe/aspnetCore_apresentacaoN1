using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gestao_de_Clientes.Controllers
{
    public class CnpjController : Controller
    {
        private readonly HttpClient _httpClient;

        public CnpjController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        [Route("api/consulta-cnpj/{cnpj}")]
        public async Task<IActionResult> ConsultaCnpj(string cnpj)
        {
            
            var apiUrl = $"https://receitaws.com.br/v1/cnpj/{cnpj}";

            try
            {
                var response = await _httpClient.GetAsync(apiUrl);
                if (!response.IsSuccessStatusCode)
                {
                    return StatusCode((int)response.StatusCode, response.ReasonPhrase);
                }

                var content = await response.Content.ReadAsStringAsync();
                return Content(content, "application/json");
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, $"Erro ao consultar CNPJ: {ex.Message}");
            }
        }
    }
}
