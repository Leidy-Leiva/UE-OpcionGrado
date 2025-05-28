namespace Api.UnidadEmprendimiento.Application.Common.Settings
{
    public class JwtSettings
    {
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public string SecretKey { get; set; } = string.Empty;
        public string ExternalIssuer { get; set; } = string.Empty;
        public string ExternalAudience { get; set; } = string.Empty;
        public string ExternalSecretKey { get; set; } = string.Empty;
        public int TokenLifetimeMinutes { get; set; }
    }
}