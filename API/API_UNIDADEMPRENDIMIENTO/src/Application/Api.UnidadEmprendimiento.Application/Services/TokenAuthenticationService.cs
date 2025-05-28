using System.Security.Claims;
using Api.UnidadEmprendimiento.Application.Interfaces;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Api.UnidadEmprendimiento.Application.Common.Settings;
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_USUARIO;

namespace Api.UnidadEmprendimiento.Application.Services
{
    // public class TokenAthenticationService : ITokenAthenticationService
    // {
//         private readonly JwtSettings _jwtSettings;
//         private readonly TokenValidationParameters _externalValidationParams;
//         public TokenAthenticationService(IOptions<JwtSettings> jwtOptions)
//         {
//             _jwtSettings = jwtOptions.Value;

//             // Configura los parámetros para validar el token externo
//             _externalValidationParams = new TokenValidationParameters
//             {
//                 ValidateIssuerSigningKey = true,
//                 IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.ExternalSecretKey)),
//                 ValidateIssuer = true,
//                 ValidIssuer = _jwtSettings.ExternalIssuer,
//                 ValidateAudience = true,
//                 ValidAudience = _jwtSettings.ExternalAudience,
//                 ValidateLifetime = true,
//                 ClockSkew = TimeSpan.FromMinutes(2)
//             };
//         }

//  public async Task<LoginResponsetDTO> AutenticarYGenerarTokenAsync(LoginRequestDTO login)
//     {
//         // 1. Simular autenticación contra sistema externo (API universidad)
//         var tokenExterno = await ObtenerTokenExternoAsync(login.USUA_NOMBREUSUARIO, login.USUA_CONTRASENIA);
//         if (string.IsNullOrEmpty(tokenExterno))
//             throw new UnauthorizedAccessException("Autenticación fallida");

//         // 2. Simular obtención de datos del usuario con ese token
//         var usuario = await ObtenerDatosUsuarioDesdeTokenExterno(tokenExterno);

//         // 3. Crear claims personalizados
//         var claims = new List<Claim>
//         {
//             new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
//             new Claim(ClaimTypes.Name, usuario.Nombre),
//             new Claim(ClaimTypes.Email, usuario.Correo)
//         };

//         // 4. Generar tu token JWT propio
//         var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
//         var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
//         var expira = DateTime.UtcNow.AddMinutes(_jwtSettings.TokenLifetimeMinutes);

//         var tokenDescriptor = new JwtSecurityToken(
//             issuer: _jwtSettings.Issuer,
//             audience: _jwtSettings.Audience,
//             claims: claims,
//             expires: expira,
//             signingCredentials: creds
//         );

//         var token = new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);

//         // 5. Devolver DTO al frontend
//         return new LoginResponsetDTO
//         {
//             TOKEN = token,
//             USUA_PNOMBRE= usuario.Nombre,
//             USUA_CORREO = usuario.Correo,
//             Expira = expira
//         };
//     }

//     private Task<string> ObtenerTokenExternoAsync(string usuario, string contrasena,)
//     {
//         // TODO: Lógica real con HttpClient
//         return Task.FromResult("token_externo_valido_simulado");
//     }

//     private Task<GetUsuarioDTO> ObtenerDatosUsuarioDesdeTokenExterno(string token)
//     {
//         // TODO: Parsear o consultar datos del usuario
//         return Task.FromResult(new GetUsuarioDTO
//         {
//             USUA_PEGEID = "",
//             USUA_NOMBREUSUARIO = "Juan Pérez",
//             USUA_CORREO = "juan@universidad.edu",
//         });
//     }

//         public string GenerateToken(LoginRequestDTO user)
//         {
//             // 1. Definir los claims internos
//             var claims = new List<Claim>
//             {
//                 new Claim(JwtRegisteredClaimNames.Sub, user.USUA_CODIGO.ToString()),
//                 new Claim("fullName", user.USUA_NOMBREUSUARIO),

//             };

//             // 2. Crear credenciales y token
//             var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
//             var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

//             var token = new JwtSecurityToken(
//                 issuer: _jwtSettings.Issuer,
//                 audience: _jwtSettings.Audience,
//                 claims: claims,
//                 expires: DateTime.UtcNow.AddMinutes(_jwtSettings.TokenLifetimeMinutes),
//                 signingCredentials: creds
//             );

//             // 3. Serializar y devolver
//             return new JwtSecurityTokenHandler().WriteToken(token);
//         }


        // public ClaimsPrincipal? ValidateExternalToken(string externalJwt)
        // {
        //           var handler = new JwtSecurityTokenHandler();
        //     try
        //     {
        //         // Valida y retorna los claims
        //         return handler.ValidateToken(externalJwt, _externalValidationParams, out _);
        //     }
        //     catch
        //     {
        //         return null;
        //     }
        // }
    }
// }