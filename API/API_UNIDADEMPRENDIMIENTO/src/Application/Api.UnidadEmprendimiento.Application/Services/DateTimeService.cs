using Api.UnidadEmprendimiento.Domain.Interfaces;

namespace Api.UnidadEmprendimiento.Application.Services
{
    public class DateTimeService:IDateTime
    {
        public DateTime NowColombia=>TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow,TimeZoneInfo.FindSystemTimeZoneById("America/Bogota"));
    }
}