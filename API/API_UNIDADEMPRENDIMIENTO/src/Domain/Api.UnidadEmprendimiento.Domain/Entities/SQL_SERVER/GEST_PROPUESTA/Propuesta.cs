using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA
{
    public class Propuesta
    {
        public int PROP_CODIGO {get; set;}
        public decimal PROP_CALIFICACION { get; set; } = 0.0m;
        public bool? PROP_ESTADO { get; set; }
        public int SALA_CODIGO { get; set; }
        public int CONP_CODIGO {get; set;}
        public  required ConvocatoriaPublicada CONVOCATORIAP {get; set;}
        public int ESTP_CODIGO {get; set;}
        public required EstadoPropuesta ESTADOPROPUESTA {get; set;}
        public ICollection <Respuesta> RESPUESTAS { get; set;}= new List<Respuesta>();
        public ICollection<PropuestaJurado> PROPUESTASJURADOS {get; set;}=new List<PropuestaJurado>();
        public ICollection <EvaluacionDetalle> EVALUACIONDETALLES {get; set;}=new List<EvaluacionDetalle>();
        public ICollection<VersionP> VERSIONES {get; set;}=new List<VersionP>();
        public ICollection<UsuarioPropuesta> USUARIOSPROPUESTAS {get; set;}=new List<UsuarioPropuesta>();
        
    }
}
