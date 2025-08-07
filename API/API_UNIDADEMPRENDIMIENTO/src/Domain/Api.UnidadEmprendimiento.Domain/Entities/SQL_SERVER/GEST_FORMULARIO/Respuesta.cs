using System.Runtime.CompilerServices;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class Respuesta
    {
        public int RESP_CODIGO {get; set; }
        public string? RESP_VALOR { get; set; }
        public DateTime RESP_FECHARESPUESTA {get; set;}
        public bool? RESP_ESTADO {get; set;}
        public int PREG_CODIGO {get; set;}
        public Pregunta PREGUNTA {get; set;}
        public int PROP_CODIGO {get; set;}
        public Propuesta PROPUESTA {get; set;}
    }
}