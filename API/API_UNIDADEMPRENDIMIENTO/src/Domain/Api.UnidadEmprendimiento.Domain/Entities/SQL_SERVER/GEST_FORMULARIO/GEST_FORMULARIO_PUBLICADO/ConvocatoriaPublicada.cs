
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class ConvocatoriaPublicada
    {
        public int CONP_CODIGO{ get; set;}
        public DateTime CONP_FECHAINICIO {get; set;}
        public DateTime CONP_FECHAFIN{get; set;}
        public int  PERS_CODIGO { get; set; }
        public  Usuario USUARIO {get; set;}=null!;
        public bool? CONP_ESTADO { get; set; }
        public ICollection <Propuesta> PROPUESTAS {get; set;}=new List<Propuesta>();
        public ICollection <FormularioPublicado> FORMULARIOSPUBLICADOS {get; set;}=new List<FormularioPublicado>();

    }
}
