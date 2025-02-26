using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO 
{
    public class Jurado
    {
        public int JURA_CODIGO {get; set;}
        public string JURA_PNOMBRE {get; set;}
        public string? JURA_SNOMBRE {get; set;}
        public string JURA_PAPELLIDO {get; set;}
        public string? JURA_SAPELLIDO {get; set;}
        public string JURA_CORREO {get; set;}
        public string JURA_TELEFONO {get; set;}
        public bool? JURA_ESTADO {get; set;}
        public ICollection <EvaluacionDetalle> EVALUACIONDETALLES {get; set;}
        public ICollection <PropuestaJurado> PROPUESTASJURADOS {get; set;}

    }
}