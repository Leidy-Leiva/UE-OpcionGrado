using System.Runtime.CompilerServices;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GES_BANCO_FORMULARIO
{
    public class BancoOpcResElemento
    {
        public int BORE_CODIGO {get; set; }
        public string? BORE_VALOR { get; set; }
        public bool? BORE_ESTADO {get; set;}
        public int? BORE_ORDEN {get;set;}
        public int BEFO_CODIGO {get; set;}
        public BancoElementoFormulario BELEMENTOF {get; set;}=null!;
    }
}