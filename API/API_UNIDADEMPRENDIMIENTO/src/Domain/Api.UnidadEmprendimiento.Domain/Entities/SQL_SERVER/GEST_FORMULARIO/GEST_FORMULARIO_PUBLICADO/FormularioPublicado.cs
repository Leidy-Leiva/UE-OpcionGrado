using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_PUBLICADO;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class FormularioPublicado
    {
        public int FORP_CODIGO { get; set; }
        public string? FORP_NOMBRE { get; set; }
        public string? FORP_DESCRIPCION { get ;set; }
        public DateTime FORP_FECHACREACION { get; set; }
        public bool? FORP_ESTADO { get; set; }
        public int TIPF_CODIGO {get; set;}
        public int CONP_CODIGO {get; set;}
        public required ConvocatoriaPublicada CONVOCATORIAPUBLICADA {get; set;}
        public required TipoFormulario TIPOFORMULARIO { get; set; }
        public int ESTF_CODIGO {get;set;}
        public EstadoFormulario ESTADOFORMULARIO { get; set; }=null!;
        public ICollection<FormularioElementoPublicado> FORMULARIOSEP {get; set;} =new List<FormularioElementoPublicado>();
        public ICollection<VersionFormularioPublicado> VERSIONESFP {get; set;} =new List<VersionFormularioPublicado>();
    }
}