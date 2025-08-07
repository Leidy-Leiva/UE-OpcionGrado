
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR
{
    public class ConvocatoriaBorrador
    {
        public int CONB_CODIGO{ get; set;}
        public DateTime CONB_FECHAINICIO {get; set;}
        public DateTime CONB_FECHAFIN{get; set;}    
        public int  PERS_CODIGO { get; set; }
        public Usuario USUARIO {get; set;}= null!;
        public bool? CONB_ESTADO { get; set; }
        public ICollection <FormularioBorrador> FORMULARIOSBORRADOR {get; set;}=new List<FormularioBorrador>();

    }
}
