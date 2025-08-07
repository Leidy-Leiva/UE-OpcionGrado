using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GES_BANCO_FORMULARIO
{
    public class BancoFormulario
    {
        public int BANF_CODIGO { get; set; }
        public string? BANF_NOMBRE { get; set; }
        public string? BANF_DESCRIPCION { get ;set; }
        public DateTime BANF_FECHACREACION { get; set; }
        public bool? BANF_ESTADO { get; set; }
        public int TIPF_CODIGO {get; set;}
        public TipoFormulario TIPOFORMULARIO { get; set; }=null!;
        public int ESTF_CODIGO {get;set;}
        public EstadoFormulario ESTADOFORMULARIO { get; set; }=null!;
        public ICollection<BancoFormularioElemento> BFORMULARIOSE {get; set;} =new List<BancoFormularioElemento>();

    }
}