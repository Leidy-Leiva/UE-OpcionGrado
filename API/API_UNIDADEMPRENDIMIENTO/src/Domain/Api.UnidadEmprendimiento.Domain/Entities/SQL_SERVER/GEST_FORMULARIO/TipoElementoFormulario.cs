
namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class TipoElementoFormulario
    {
        public int TPEF_CODIGO {get; set;}
        public string? TPEF_NOMBRE { get; set; }
        public bool? TPEF_ESTADO { get; set; }
        public ICollection <ElementoFormularioPublicado> ELEMENTOSFP { get; set; }  = new List<ElementoFormularioPublicado>();
        public ICollection <ElementoFormularioBorrador> ELEMENTOSFB { get; set; }= new List<ElementoFormularioBorrador>();
        public ICollection <BancoElementoFormulario> BELEMENTOSF { get; set; }  = new List<BancoElementoFormulario>();

    }
}