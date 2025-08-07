
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GES_BANCO_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class EstadoFormulario
    {
        public int ESTF_CODIGO {get; set;}
        public string? ESTF_NOMBRE { get; set; }
        public bool? ESTF_ESTADO { get; set; }
        public ICollection <FormularioPublicado> FORMULARIOSPUBLICADOS { get; set; }= new List<FormularioPublicado>();
        public ICollection <FormularioBorrador> FORMULARIOSBORRADOR { get; set; }= new List<FormularioBorrador>();
        public ICollection <BancoFormulario> BANCOFORMULARIOS { get; set; }= new List<BancoFormulario>();

    }
}