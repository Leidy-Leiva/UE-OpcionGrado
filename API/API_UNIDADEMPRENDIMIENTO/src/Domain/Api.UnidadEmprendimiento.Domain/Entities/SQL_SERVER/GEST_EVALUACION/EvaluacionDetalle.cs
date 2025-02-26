using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION
{
    public class EvaluacionDetalle
    {
        public int EVDE_CODIGO {get; set;}
        public string? EVDE_COMENTARIO {get; set;}
        public decimal EVDE_CALIFICACION { get; set; } = 0.0m;
        public bool? EVDE_ESTADO {get; set;}
        public int EVAL_CODIGO {get; set;}
        public Evaluacion EVALUACION {get; set;}
        public int PROP_CODIGO {get; set;}
        public  Propuesta PROPUESTA {get; set;}
        public int JURA_CODIGO {get; set;}
        public Jurado JURADO {get; set;}
    }
}