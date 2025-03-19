using System.Runtime.CompilerServices;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class OpcRespuestaPublicado
    {
        public int OPRP_CODIGO {get; set; }
        public string? OPRP_VALOR { get; set; }
        public int OPRP_ORDEN {get; set;}
        public bool? OPRP_ESTADO {get; set;}
        public int EFOP_CODIGO {get; set;}
        public required  ElementoFormularioPublicado ELEMENTOFP {get; set;}
    }
}