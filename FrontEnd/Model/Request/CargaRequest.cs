using FrontEnd.Models.Response;

namespace FrontEnd.Model.Request
{
    public class CargaRequest
    {        
        public decimal CalcularCustoFrete(CargaResponse carga)
        {
            var valorFixoPorKm = 0.50m;
            var valorAdicionalPorKg = 1.00m;
            var valorAdicionalPorM3 = 2.00m;

            var volume = carga.Largura * carga.Altura * carga.Comprimento;

            return (carga.Distancia * valorFixoPorKm) +
                   (carga.Peso * valorAdicionalPorKg) +
                   (volume * valorAdicionalPorM3);
        }
    }
}
