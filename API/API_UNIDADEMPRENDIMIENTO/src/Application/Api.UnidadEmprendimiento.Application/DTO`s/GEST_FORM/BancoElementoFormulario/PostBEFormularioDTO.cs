
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoOpcResElemento;


namespace Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoElementoFormulario
{
    public class PostBEFormularioDTO
    {
        public string? BEFO_ENUNCIADO { get; set; }
        public int TEFO_CODIGO { get; set; }
         public int BEFO_ORDEN { get; set; }
         public List<PostBORElementoDTO> BANCOOPCRESELEMENTOS { get; set; } = new(); 
     
    }
}
