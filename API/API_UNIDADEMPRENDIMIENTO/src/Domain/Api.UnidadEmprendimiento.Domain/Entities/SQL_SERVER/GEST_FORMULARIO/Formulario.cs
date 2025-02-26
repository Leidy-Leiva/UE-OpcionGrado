using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class Formulario
    {
        public int FORM_CODIGO { get; set; }
        public string? FORM_NOMBRE { get; set; }
        public string? FORM_DESCRIPCION { get ;set; }
        public DateTime FORM_FECHACREACION { get; set; }
        public bool? FORM_ESTADO { get; set; }
        public int TIPF_CODIGO {get; set;}
        public TipoFormulario TIPOFORMULARIO { get; set; }
        public ICollection<Seccion> SECCIONES { get; set; }
        public ICollection<ConvocatoriaFormulario> CONVOCATORIASFORMULARIOS { get; set; }

    }
}