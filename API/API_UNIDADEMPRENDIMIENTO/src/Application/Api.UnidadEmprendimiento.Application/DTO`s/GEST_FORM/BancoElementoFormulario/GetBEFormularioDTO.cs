
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoOpcResElemento;



namespace Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoElementoFormulario
{
    public class GetBEFormularioDTO
    {
        public string? BEFO_ENUNCIADO { get; set; }
        public string TEFO_CODIGO { get; set; }
        public List<GetBORElementoDTO> BANCOOPCRESELEMENTOS { get; set; }
    }
}
