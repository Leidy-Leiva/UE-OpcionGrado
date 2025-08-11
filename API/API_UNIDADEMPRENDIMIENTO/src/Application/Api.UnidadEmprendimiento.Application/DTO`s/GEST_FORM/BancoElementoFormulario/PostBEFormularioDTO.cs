
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.Respuesta;

namespace Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.Pregunta
{
    public class PostBEFormularioDTO
    {
        public string? BEFO_ENUNCIADO { get; set; }
        public int TEFO_CODIGO { get; set; }
        public IEnumerable<PostBORRElementoDTO?> BANCOOPCRESELEMENTOS {get;set;}
    }
}
