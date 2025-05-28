using System.Net.Http.Json;
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_USUARIO;
using Api.UnidadEmprendimiento.Application.Interfaces;

namespace Api.UnidadEmprendimiento.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }
        public async Task<LoginResponseDTO> LoginAsync(LoginRequestDTO modelDTO)
        {
            var url = "https://chaira.uniamazonia.edu.co/AppChaira/api/v1/usuario/";

            var response = await _httpClient.PostAsJsonAsync(url, modelDTO);

            if (!response.IsSuccessStatusCode)
                throw new Exception("Error al Authenticar con la Api externa");

            var external = await response.Content.ReadFromJsonAsync<LoginResponseDTO>();

            return new LoginResponseDTO
            {
                status = external.status,
                answer = external.answer,
                token = external.token




            };

        }
    }
}