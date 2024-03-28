using BackEnd.Model.Enum;
using BackEnd.Model.Request;
using BackEnd.Model.Response;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadorFreteController : ControllerBase
    {
        [HttpGet]
        [Route("calcular")]
        public IActionResult CalcularFrete([FromQuery] CargaRequest requisicao)
        {
            var volumeTotal = requisicao.AlturaPacote * requisicao.LarguraPacote;

            var distanciaTotalKm = requisicao.DistanciaTotal / TaxasAdicionais.TaxaPorKilometro;

            var pesoTotal = requisicao.PesoCarga * TaxasAdicionais.TaxaPorQuilograma;

            var custoTotalFrete = (distanciaTotalKm * pesoTotal) / volumeTotal;

            var custoFreteFormatado = Math.Round(custoTotalFrete, 2).ToString("0.00");

            var respostaCalculoFrete = new CargaResponse
            {
                DistanciaTotal = requisicao.DistanciaTotal,
                AlturaPacote = requisicao.AlturaPacote,
                LarguraPacote = requisicao.LarguraPacote,
                PesoCarga = requisicao.PesoCarga,
                CustoFrete = Convert.ToDecimal(custoFreteFormatado)
            };

            return Ok(respostaCalculoFrete);
        }
    }
}
