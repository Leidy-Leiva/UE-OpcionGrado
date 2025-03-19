using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GES_BANCO_FORMULARIO;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR{

public class BancoFormularioElemento
    {
        public int BFOE_CODIGO {get; set;}
        public bool? BFOE_ESTADO {get; set;}
        public int BEFO_CODIGO {get;set;}
        public BancoElementoFormulario ELEMENTOFORMULARIO{get; set;}=null!;
        public int BANF_CODIGO {get;set;}
        public BancoFormulario FORMULARIO{get; set;}=null!;

    }
}