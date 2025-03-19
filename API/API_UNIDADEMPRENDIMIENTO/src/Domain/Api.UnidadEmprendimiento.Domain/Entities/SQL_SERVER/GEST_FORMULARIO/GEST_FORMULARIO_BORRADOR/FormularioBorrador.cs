using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR
{
    public class FormularioBorrador
    {
        public int FORB_CODIGO { get; set; }
        public string? FORB_NOMBRE { get; set; }
        public string? FORB_DESCRIPCION { get ;set; }
        public DateTime FORB_FECHACREACION { get; set; }
        public bool? FORB_ESTADO { get; set; }
        public int TIPF_CODIGO {get; set;}
        public required TipoFormulario TIPOFORMULARIO { get; set; }
        public int ESTF_CODIGO {get;set;}
        public EstadoFormulario ESTADOFORMULARIO { get; set; }=null!;
         public int CONB_CODIGO {get; set;}
        public ConvocatoriaBorrador CONVOCATORIABORRADOR {get; set;}=null!;
         public ICollection<FormularioElementoBorrador> FORMULARIOSEB {get; set;} =new List<FormularioElementoBorrador>();

    }
}