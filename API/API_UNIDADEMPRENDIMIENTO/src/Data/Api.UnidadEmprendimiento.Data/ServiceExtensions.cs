using Api.UnidadEmprendimiento.Data.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Api.UnidadEmprendimiento.Domain.Interfaces;
using Api.UnidadEmprendimiento.Data.Repository;
using static System.Formats.Asn1.AsnWriter;


namespace Api.UnidadEmprendimiento.Data
{
    public static class ServiceExtensions
    {
        public static void AddPersistenceData(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = Environment.GetEnvironmentVariable("ConnectionDB")
           ?? configuration.GetConnectionString("Connection");

            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(
                   connectionString,
                   sqlOptions =>
                   {
                       sqlOptions.EnableRetryOnFailure();
                   }
       ));
        }



        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddTransient<ITipoElementoRepository, TipoElementoRepository>();
            services.AddTransient<ITipoFormularioRepository, TipoFormularioRepository>();
            services.AddTransient<IBancoElementoFormularioRepository, BancoElementoFormularioRepository>();
            // services.AddTransient<IUsuarioRepository, UsuarioRepository>();

        }


    }
}