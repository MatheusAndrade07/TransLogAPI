using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Model.Request
{
    public class CargaRequest
    {
        [Required(ErrorMessage = "A distância é um campo obrigatório.")]
        public decimal DistanciaTotal { get; set; }

        [Required(ErrorMessage = "A altura é um campo obrigatório.")]
        public decimal AlturaPacote { get; set; }

        [Required(ErrorMessage = "A largura é um campo obrigatório.")]
        public decimal LarguraPacote { get; set; }

        [Required(ErrorMessage = "O peso da carga é um campo obrigatório.")]
        public decimal PesoTotalCarga { get; set; }
    }
}
