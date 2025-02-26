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
        public int PERS_PEGEID{get; set;}
        
    }
}