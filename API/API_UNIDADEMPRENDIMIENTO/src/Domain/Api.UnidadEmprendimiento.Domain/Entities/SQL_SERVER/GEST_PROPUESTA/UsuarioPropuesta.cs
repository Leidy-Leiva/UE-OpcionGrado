using System.Dynamic;
using System.Runtime.CompilerServices;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA
{
    public class UsuarioPropuesta
    {   
        public int USUP_CODIGO {get; set;}
        public bool? USUP_ESTADO {get; set;}
        public DateTime? USUP_FECHAASOCIACION {get; set;}
        public int PERS_CODIGO {get; set;}
        public required Usuario USUARIO {get; set;}
        public int PROP_CODIGO {get;set;}
        public required Propuesta PROPUESTA{get; set;}



    }
}