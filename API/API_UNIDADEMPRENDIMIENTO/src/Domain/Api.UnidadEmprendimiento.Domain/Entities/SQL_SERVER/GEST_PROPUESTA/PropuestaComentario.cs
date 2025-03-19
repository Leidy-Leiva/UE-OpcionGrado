using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_PUBLICADO;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA{

    public class PropuestaComentario{
        public int PROC_CODIGO {get; set; }
        public DateTime PROC_FECHACREACION {get; set;}
        public string? PROC_COMENTARIO {get; set;}
        public int VFOP_CODIGO{get; set;}
        public required VersionFormularioPublicado VERSIONFP{get;set;}


    }
}