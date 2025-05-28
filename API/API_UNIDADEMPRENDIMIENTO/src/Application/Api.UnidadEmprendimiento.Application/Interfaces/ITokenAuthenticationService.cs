using System.Security.Claims;
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_USUARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO;

namespace Api.UnidadEmprendimiento.Application.Interfaces
{
    public interface ITokenAthenticationService
    {

        // ClaimsPrincipal? ValidateExternalToken(string externalJwt);

        Task<LoginResponseDTO> AutenticarYGenerarTokenAsync(LoginRequestDTO login);
    }

}
