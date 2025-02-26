namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class TipoFormulario
    {
        public int TIPF_CODIGO {get; set;}
        public string? TIPF_NOMBRE { get; set; }
        public bool? TIPF_ESTADO {get; set; }
        public ICollection <Formulario> FORMULARIOS {get; set;}
    } 
}