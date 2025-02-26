using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class ConvocatoriaFormulario
    {
        public int COFO_CODIGO {get; set;}
        public bool? COFO_ESTADO {get; set;}
        public int FORM_CODIGO { get; set; }
        public Formulario FORMULARIO {get; set;}
        public int CONV_CODIGO {get; set;}
        public Convocatoria CONVOCATORIA {get; set;}
    }
}