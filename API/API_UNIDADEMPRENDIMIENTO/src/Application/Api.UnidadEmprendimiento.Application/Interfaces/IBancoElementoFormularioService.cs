using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.Pregunta;

namespace Api.UnidadEmprendimiento.Application.Interfaces
{
    public interface IBancoElementoFormularioService
    {
        Task<List<GetBEFormularioDTO>> MostrarPreguntas();
        Task<PostBEFormularioDTO> Registrar(PostBEFormularioDTO modelDTO);
        Task<bool> Actualizar(PutBEFormularioDTO modelDTO);
    }
}