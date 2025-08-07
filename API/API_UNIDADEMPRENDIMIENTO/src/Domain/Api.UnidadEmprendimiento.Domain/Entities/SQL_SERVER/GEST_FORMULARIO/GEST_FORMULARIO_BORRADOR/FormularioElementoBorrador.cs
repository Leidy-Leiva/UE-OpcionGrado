namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR{

    public class FormularioElementoBorrador
        {
            public int FOEB_CODIGO {get; set;}
            public int EFOB_CODIGO {get;set;}
            public bool?  FOEB_ESTADO {get;set;}
            public ElementoFormularioBorrador ELEMENTOBORRADOR{get; set;}=null!;
            public int FORB_CODIGO {get;set;}
            public required FormularioBorrador FORMULARIOBORRADOR{get; set;}=null!;

        }
}