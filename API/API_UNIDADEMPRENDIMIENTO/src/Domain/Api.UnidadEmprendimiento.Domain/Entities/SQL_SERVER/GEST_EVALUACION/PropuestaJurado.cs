using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION
{
    public class PropuestaJurado
    {
        public int PROJ_CODIGO {get; set;}
        public DateTime PROJ_FECHAASIGNACION {get; set;}
        public bool? PROPJ_ESTADO {get; set;}
        public int PROP_CODIGO{ get; set;}
        public Propuesta PROPUESTA { get; set;}
        public int JURA_CODIGO {get; set;}
        public Jurado JURADO {get; set;}
    }
}