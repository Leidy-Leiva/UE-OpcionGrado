using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
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

        // public async Task<GetUsuarioDTO> ObtenerDatosBasicosAsync(string token, string pegeId)
        // {
        //     var url = "https://chaira.uniamazonia.edu.co/AppChaira/api/v1/usuario/DatosBasicos";

        //     var request = new HttpRequestMessage(HttpMethod.Post, url);
        //     request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

        //     var body = new { pg_Id = pegeId };
        //     request.Content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");

        //     var response = await _httpClient.SendAsync(request);

        //     if (!response.IsSuccessStatusCode)
        //         throw new Exception("No se pudieron obtener los datos básicos del usuario");

        //     var jsonResponse = await response.Content.ReadAsStringAsync();

        //     return JsonSerializer.Deserialize<GetUsuarioDTO>(jsonResponse, new JsonSerializerOptions
        //     {
        //         PropertyNameCaseInsensitive = true
        //     });
        // }


        // public async Task<GetUsuarioDTO> ObtenerDatosBasicosAsync(string token, string pegeId)
        // {
        //     var url = "https://chaira.uniamazonia.edu.co/AppChaira/api/v1/usuario/DatosBasicos";

        //     var request = new HttpRequestMessage(HttpMethod.Post, url);
        //     request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

        //     var body = new { pg_Id = pegeId };
        //     request.Content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");

        //     var response = await _httpClient.SendAsync(request);

        //     var jsonResponse = await response.Content.ReadAsStringAsync();

        //     if (!response.IsSuccessStatusCode)
        //     {
        //         // Aquí verás qué mensaje da la API (puede no ser JSON)
        //         throw new Exception($"No se pudieron obtener los datos básicos del usuario. Status: {response.StatusCode}. Respuesta: {jsonResponse}");
        //     }

        //     // DEBUG: imprime o retorna el json para verificar su estructura
        //     Console.WriteLine("Respuesta JSON de la API externa:");
        //     Console.WriteLine(jsonResponse);

        //     // Intenta deserializar solo si la respuesta es JSON válido y esperado
        //     var datos = JsonSerializer.Deserialize<GetUsuarioDTO>(jsonResponse, new JsonSerializerOptions
        //     {
        //         PropertyNameCaseInsensitive = true
        //     });

        //     return datos;
        // }


        public async Task<GetUsuarioDTO> ObtenerDatosBasicosAsync(string token, string pegeId)
        {
            var url = "https://chaira.uniamazonia.edu.co/AppChaira/api/v1/usuario/DatosBasicos";

            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var body = new { pg_Id = pegeId };
            request.Content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(request);

            var jsonResponse = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"No se pudieron obtener los datos básicos del usuario. Status: {response.StatusCode}. Respuesta: {jsonResponse}");
            }

            var datosList = JsonSerializer.Deserialize<List<GetUsuarioDTO>>(jsonResponse, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (datosList == null || datosList.Count == 0)
                throw new Exception("No se encontraron datos del usuario");

            return datosList[0];
        }


    }
}