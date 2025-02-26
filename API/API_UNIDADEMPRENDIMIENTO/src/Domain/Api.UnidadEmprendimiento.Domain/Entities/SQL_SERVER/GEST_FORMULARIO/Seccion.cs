namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO
{
    public class Seccion
    {
        public int SECC_CODIGO {get; set; }
        public string? SECC_NOMBRE { get; set;}
        public int? SECC_ORDEN { get; set; }
        public bool? SECC_ESTADO { get; set; }
        public ICollection <Pregunta> PREGUNTAS { get; set; }
        public int FORM_CODIGO {get; set;}
        public Formulario FORMULARIO { get; set; }


    }
}