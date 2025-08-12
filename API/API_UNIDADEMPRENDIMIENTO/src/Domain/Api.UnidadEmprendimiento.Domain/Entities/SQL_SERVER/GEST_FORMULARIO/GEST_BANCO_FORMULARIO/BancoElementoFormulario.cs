using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GES_BANCO_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class BancoElementoFormulario
    {
        public int BEFO_CODIGO {get; set; }
        public string? BEFO_ENUNCIADO {get; set; }
        public int BEFO_ORDEN {get; set;}
        public bool? BEFO_ESTADO {get; set;}
        public int TEFO_CODIGO {get; set;}
        public string? BEFO_DATOSJSON { get; set; }   
        public required TipoElementoFormulario TIPOELEMENTOF { get; set; }
        public ICollection <BancoOpcResElemento> BANCOOPCRESELEMENTOS {get; set;}=new List<BancoOpcResElemento>();
        public ICollection<BancoFormularioElemento> BFORMULARIOSE {get; set;} =new List<BancoFormularioElemento>();


    }
}    