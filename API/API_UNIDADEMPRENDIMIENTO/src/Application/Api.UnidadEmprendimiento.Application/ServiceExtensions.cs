using Api.UnidadEmprendimiento.Domain.Interfaces;
using Api.UnidadEmprendimiento.Application.Services;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Api.UnidadEmprendimiento.Application.Interfaces;
using Microsoft.Extensions.Http;

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
            services.AddTransient<ITipoElementoService, TipoElementoService>();
            services.AddTransient<ITipoFormularioService, TipoFormularioService>();

                   services.AddHttpClient<IAuthService, AuthService>(client =>
     {
         client.BaseAddress = new Uri(configuration["AuthApi:BaseUrl"]);
     });

        }
    }


}


