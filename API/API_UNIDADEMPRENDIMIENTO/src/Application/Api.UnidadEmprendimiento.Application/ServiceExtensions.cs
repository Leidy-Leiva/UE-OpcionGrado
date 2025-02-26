using Api.UnidadEmprendimiento.Domain.Interfaces;
using Api.UnidadEmprendimiento.Application.Services;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Api.UnidadEmprendimiento.Application.Interfaces;

namespace Api.UnidadEmprendimiento.Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<ITipoPreguntaService, TipoPreguntaService>();
            services.AddTransient<ITipoFormularioService, TipoFormularioService>();

        }
    }
}

