using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GES_BANCO_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class TipoFormulario
    {
        public int TIPF_CODIGO {get; set;}
        public string? TIPF_NOMBRE { get; set; }
        public bool? TIPF_ESTADO {get; set; }
        public ICollection <FormularioPublicado> FORMULARIOSP {get; set;}=new List <FormularioPublicado>();
        public ICollection <FormularioBorrador> FORMULARIOSB {get; set;}=new List <FormularioBorrador>();
        public ICollection <BancoFormulario> BANCOFORMULARIOS {get; set;}=new List <BancoFormulario>();
    } 
}