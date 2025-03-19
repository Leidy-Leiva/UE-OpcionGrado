using System.Runtime.CompilerServices;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class OpcRespuestaBorrador
    {
        public int OPRB_CODIGO {get; set; }
        public string? OPRB_VALOR { get; set; }
        public bool? OPRB_ESTADO {get; set;}
        public int? OPRB_ORDEN {get; set;}

        public int EFOB_CODIGO {get; set;}
        public required  ElementoFormularioBorrador ELEMENTOFB {get; set;}
    }
}