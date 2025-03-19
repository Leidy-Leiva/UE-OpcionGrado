using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class ElementoFormularioBorrador
    {
        public int EFOB_CODIGO {get; set; }
        public string? EFOB_ENUNCIADO {get; set; }
        public int? EFOB_ORDEN {get; set;}
        public bool? EFOB_ESTADO {get; set;}
       public int TEFO_CODIGO {get; set;}

         public string? EFOB_DATOSJSON { get; set; }   
         public required TipoElementoFormulario TIPOELEMENTOF { get; set; }
        public ICollection <OpcRespuestaBorrador> OPCRESPUESTASBORRADOR {get; set;}=new List<OpcRespuestaBorrador>();
        
        public ICollection<FormularioElementoBorrador> FORMULARIOEB {get; set;} =new List<FormularioElementoBorrador>();

    }
}