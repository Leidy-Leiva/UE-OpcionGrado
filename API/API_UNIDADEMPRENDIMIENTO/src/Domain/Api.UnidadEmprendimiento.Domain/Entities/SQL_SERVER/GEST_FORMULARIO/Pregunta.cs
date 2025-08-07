namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class Pregunta
    {
        public int PREG_CODIGO {get; set; }
        public string? PREG_ENUNCIADO {get; set; }
        public int? PREG_ORDEN {get; set;}
        public bool? PREG_ESTADO {get; set;}
        public int TIPR_CODIGO {get; set;}
        public TipoPregunta TIPOPREGUNTA { get; set; }
        public int SECC_CODIGO {get; set;}
        public Seccion SECCION { get; set; }  
        public ICollection <Respuesta> RESPUESTAS {get; set;}

    }
}