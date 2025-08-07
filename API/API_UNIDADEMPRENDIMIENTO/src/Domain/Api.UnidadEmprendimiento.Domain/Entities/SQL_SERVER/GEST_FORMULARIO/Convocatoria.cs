
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class Convocatoria
    {
        public int CONV_CODIGO{ get; set;}
        public DateTime CONV_FECHAINICIO {get; set;}
        public DateTime CONV_FECHAFIN{get; set;}
        public int  PERS_CODIGO { get; set; }
        public bool? CONV_ESTADO { get; set; }
        public ICollection <Propuesta> PROPUESTAS {get; set;}
        public ICollection<ConvocatoriaFormulario> CONVOCATORIASFORMULARIOS {get; set;}

    }
}
