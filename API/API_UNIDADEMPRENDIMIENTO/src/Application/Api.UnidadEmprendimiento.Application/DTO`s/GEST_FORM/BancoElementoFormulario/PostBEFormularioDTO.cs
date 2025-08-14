
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoOpcResElemento;
using System.ComponentModel.DataAnnotations;


namespace Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoElementoFormulario
{
    public class PostBEFormularioDTO
    {
        [Required(ErrorMessage = "El enunciado es obligatorio")]
        [StringLength(500, ErrorMessage = "Máx 500 caracteres")]
        public string? BEFO_ENUNCIADO { get; set; }

        [Required(ErrorMessage = "Tipo de pregunta obligatorio")]
        public int TEFO_CODIGO { get; set; }
        public int BEFO_ORDEN { get; set; }
        public List<PostBORElementoDTO> BANCOOPCRESELEMENTOS { get; set; } = new();

    }
}
