using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION
{
    public class Evaluacion 
    {
        public int EVAL_CODIGO {get; set;}
        public decimal EVAL_PROMEDIOCALIFICACION { get; set; } = 0.0m;
        public DateTime EVAL_FECHACALIFICACION { get; set;}
        public string? EVAL_COMENTARIO { get; set; }
        public bool? EVAL_ESTADO { get; set; }
        public ICollection <EvaluacionDetalle> EVALUACIONDETALLES {get; set;}
        public ICollection <Item> ITEMS {get; set;}

    }
}