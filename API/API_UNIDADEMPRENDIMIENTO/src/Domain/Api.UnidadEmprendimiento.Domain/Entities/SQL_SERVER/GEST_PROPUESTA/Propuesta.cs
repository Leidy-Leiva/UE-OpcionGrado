using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA
{
    public class Propuesta
    {
        public int PROP_CODIGO {get; set;}
        public string? PROP_TITULO { get; set; }
        public string? PROP_DESCRIPCION { get; set; }
        public string? PROP_PRESENTACION {get; set;}
        public decimal PROP_CALIFICACION { get; set; } = 0.0m;
        public bool? PROP_ESTADO { get; set; }
        public int SALA_CODIGO { get; set; }
        public int CONV_CODIGO {get; set;}
        public Convocatoria CONVOCATORIA {get; set;}
        public int ESTP_CODIGO {get; set;}
        public EstadoPropuesta ESTADOPROPUESTA {get; set;}
        public ICollection <Respuesta> RESPUESTAS { get; set;}
        public ICollection<PropuestaJurado> PROPUESTASJURADOS {get; set;}
        public ICollection <EvaluacionDetalle> EVALUACIONDETALLES {get; set;}
       
        
    }
}
