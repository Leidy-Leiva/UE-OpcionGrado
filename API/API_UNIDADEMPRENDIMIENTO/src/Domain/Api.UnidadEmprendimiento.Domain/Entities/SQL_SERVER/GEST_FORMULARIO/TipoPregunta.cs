
namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class TipoPregunta
    {
        public int TIPR_CODIGO {get; set;}
        public string? TIPR_NOMBRE { get; set; }
        public bool? TIPR_ESTADO { get; set; }
        public ICollection <Pregunta> PREGUNTAS { get; set; }  

    }
}