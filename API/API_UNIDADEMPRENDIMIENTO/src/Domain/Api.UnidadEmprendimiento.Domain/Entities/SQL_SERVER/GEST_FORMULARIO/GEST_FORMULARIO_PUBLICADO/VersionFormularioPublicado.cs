
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_PUBLICADO
{
    public class VersionFormularioPublicado
    {
       public int VFOP_CODIGO{ get;set;}
       public DateTime VFOP_FECHA {get;set;}
       public bool? VFOP_ESTADO {get;set;}
       public int FORP_CODIGO{get;set;}
       public required FormularioPublicado FORMULARIOPUBLICADO{get; set;}
       public int VERS_CODIGO{get;set;}
       public required VersionP VERSION {get; set;}
       public ICollection<PropuestaComentario> PROPUESTASCOMENTARIOS {get; set;}= new List<PropuestaComentario>();
    }
}