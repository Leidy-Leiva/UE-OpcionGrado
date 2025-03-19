using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO
{
    public class Usuario
    {
        public int USUA_CODIGO {get; set;}
        public string USUA_PNOMBRE {get; set;}
        public string? USUA_SNOMBRE {get; set;}
        public string USUA_PAPELLIDO {get; set;}
        public string? USUA_SAPELLIDO {get; set;}
        public string USUA_NOMBREUSUARIO {get; set;}
        public string USUA_CONTRASENIA {get; set;}
        public bool? USUA_ESTADO {get; set;}
        public int PERS_CODIGO{get; set;}
        public ICollection<UsuarioPropuesta> USUARIOSPROPUESTAS {get; set;}= new List<UsuarioPropuesta>();
        public ICollection<ConvocatoriaPublicada> CONVOCATORIASPUBLICADAS {get; set;}= new List<ConvocatoriaPublicada>();
        public ICollection<ConvocatoriaBorrador> CONVOCATORIASBORRADOR {get; set;}= new List<ConvocatoriaBorrador>();
        public ICollection<VersionP> VERSIONES {get; set;}=new List <VersionP>();

    }
}