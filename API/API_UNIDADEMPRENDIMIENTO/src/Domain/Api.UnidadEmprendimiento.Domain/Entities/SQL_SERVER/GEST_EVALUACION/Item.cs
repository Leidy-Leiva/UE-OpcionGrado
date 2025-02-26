using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION
{
    public class Item 
    {
        public int ITEM_CODIGO{get; set;}
        public string? ITEM_NOMBRE { get;set; }
        public bool? ITEM_ESTADO { get; set;}
        public decimal ITEM_PUNTAJEMAXIMO {get; set; }=0.0m;
        public string? ITEM_COMENTARIO { get;set; }
        public int EVAL_CODIGO {get; set;}
        public Evaluacion EVALUACION { get; set; }
    }
}