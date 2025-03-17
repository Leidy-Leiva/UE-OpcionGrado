namespace Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_PUBLICADO
{
    public class FormularioElementoPublicado
    {
        public int FOEP_CODIGO {get; set;}
        public int EFOP_CODIGO {get;set;}
        public required ElementoFormularioPublicado ELEMENTOFP{get; set;}
         public int FORP_CODIGO {get;set;}
        public required FormularioPublicado FORMULARIOP{get; set;}
        public bool? FOEP_ESTADO {get;set;}
    }



}