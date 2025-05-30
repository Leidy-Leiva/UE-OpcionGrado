using Api.UnidadEmprendimiento.Application.DTO_s.GEST_USUARIO;

namespace Api.UnidadEmprendimiento.Application.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDTO> LoginAsync(LoginRequestDTO modelDTO);
        Task<GetUsuarioDTO> ObtenerDatosBasicosAsync(string token, string pegeId);

    }
}