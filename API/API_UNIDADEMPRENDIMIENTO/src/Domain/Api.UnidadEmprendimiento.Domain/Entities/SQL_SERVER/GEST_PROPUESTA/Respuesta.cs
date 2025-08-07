
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA
{
    public class Respuesta{
        public int RESP_CODIGO {get; set; }
        public string? RESP_VALOR { get; set; }
        public DateTime RESP_FECHARESPUESTA {get; set;}
        public bool? RESP_ESTADO {get; set;}
        public int EFOP_CODIGO {get; set;}
        public ElementoFormularioPublicado ELEMENTOFP {get; set;}=null!;
        public int PROP_CODIGO {get; set;}
        public required  Propuesta PROPUESTA {get; set;}
    }
}