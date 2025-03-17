

using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_PUBLICADO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA
{
    public class VersionP
    {
        public int VERS_CODIGO {get; set;}
        public DateTime VERS_FECHAMOFICIACION {get;set;}
        public int VERS_NUMERO {get; set;}
        public string? VERS_COMENTARIO {get; set;}
        public bool? VERS_ESTADO {get; set;}
        public int PERS_CODIGO {get; set;}
        public Usuario USUARIO {get; set;}=null!;
        public Propuesta PROPUESTA {get; set;}=null!;
        public ICollection<VersionFormularioPublicado> VERSIONESFP {get; set;} =new List<VersionFormularioPublicado>();


    }

}