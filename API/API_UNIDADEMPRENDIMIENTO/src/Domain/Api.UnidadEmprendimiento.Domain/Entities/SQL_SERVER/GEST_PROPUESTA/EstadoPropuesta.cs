using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;

namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA
{
    public class EstadoPropuesta
    {
        public int ESTP_CODIGO {get; set;}
        public string? ESTP_NOMBRE { get; set; }
        public ICollection<Propuesta> PROPUESTAS { get; set;}
        public bool? ESTP_ESTADO {get; set;}
        
    }
}
