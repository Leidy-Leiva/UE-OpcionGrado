using Api.UnidadEmprendimiento.Application.DTO_s.GEST_USUARIO;
using Api.UnidadEmprendimiento.Application.Interfaces;
using Api.UnidadEmprendimiento.Application.Services;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Api.UnidadEmprendimiento.Controller.V1
{

    [Route("Api/V1/[controller]")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO request)
        {
            try
            {
                var result = await _authService.LoginAsync(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error durante el login: {ex.Message}");
            }

        }

        [HttpPost("DatosPersonales")]
        public async Task<IActionResult> ObtenerDatos(
        [FromHeader(Name = "token")] string token,
        [FromBody] GetInfoDTO request)
        {
            try
            {
                var datos = await _authService.ObtenerDatosBasicosAsync(token, request.pg_Id);
                return Ok(datos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener datos básicos: {ex.Message}");
            }
        }



    }
}

