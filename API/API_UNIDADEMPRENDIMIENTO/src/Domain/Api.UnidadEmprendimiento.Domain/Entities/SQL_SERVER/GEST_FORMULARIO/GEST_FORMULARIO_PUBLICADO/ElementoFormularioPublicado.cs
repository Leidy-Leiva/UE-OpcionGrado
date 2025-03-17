using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_PUBLICADO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class ElementoFormularioPublicado
    {
        public int  EFOP_CODIGO {get; set; }
        public string?  EFOP_ENUNCIADO {get; set; }
        public int?  EFOP_ORDEN {get; set;}
        public bool?  EFOP_ESTADO {get; set;}
        public int TEFO_CODIGO {get; set;}
        public string? EFOP_DATOSJSON { get; set; }   
        public TipoElementoFormulario TIPOELEMENTOF { get; set; }=null!;
        public ICollection <OpcRespuestaPublicado> OPCRESPUESTASPUBLICADOS {get; set;}=new List<OpcRespuestaPublicado>();
        public ICollection <FormularioElementoPublicado> FORMULARIOSEP {get; set;}=new List<FormularioElementoPublicado>();
        public ICollection<Respuesta> RESPUESTAS {get;set;}=new List<Respuesta>();

    }
}