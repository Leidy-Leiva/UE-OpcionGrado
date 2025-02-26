using  Microsoft.EntityFrameworkCore;
using System.Reflection;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
namespace Api.UnidadEmprendimiento.Data.Contexts 
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
          
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; // Controla el comportamiento de seguimiento de consultas
        }
        public DbSet<Evaluacion> Evaluaciones {get; set;}
        public DbSet<EvaluacionDetalle> EvaluacionesDetalles {get; set;}
        public DbSet<Item> Items {get; set;}
        public DbSet<PropuestaJurado> PropuestasJurados {get; set;}
        public DbSet<Convocatoria> Convocatorias {get; set;}
        public DbSet<ConvocatoriaFormulario> ConvocatoriasFormularios {get; set;}
        public DbSet<Formulario> Formularios {get; set;}
        public DbSet<Pregunta> Preguntas {get; set;}
        public DbSet<Respuesta> Respuestas {get; set;}
        public DbSet<Seccion> Secciones {get; set;}
        public DbSet<TipoFormulario> TiposFormularios {get; set;}
        public DbSet<TipoPregunta> TiposPreguntas {get; set;}
        public DbSet<EstadoPropuesta> EstadosPropuestas {get; set;}
        public DbSet<Propuesta> Propuestas {get; set;}
        public DbSet<Jurado> Jurados {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}