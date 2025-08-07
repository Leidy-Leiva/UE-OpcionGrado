using  Microsoft.EntityFrameworkCore;
using System.Reflection;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GES_BANCO_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_PUBLICADO;
namespace Api.UnidadEmprendimiento.Data.Contexts 
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
          
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; // Controla el comportamiento de seguimiento de consultas
        }

        /*EVALUACIONES*/
        public DbSet<Evaluacion> Evaluaciones {get; set;}
        public DbSet<EvaluacionDetalle> EvaluacionesDetalles {get; set;}
        public DbSet<Item> Items {get; set;}
        public DbSet<PropuestaJurado> PropuestasJurados {get; set;}

        /*FORMULARIOS*/
        public DbSet<TipoFormulario> TiposFormularios {get; set;}
        public DbSet<TipoElementoFormulario> TipoElementosFormularios {get; set;}
        public DbSet<EstadoFormulario> EstadoFormularios {get; set;}
        
        /*FORMULARIO BORRADOR*/
        public DbSet<ConvocatoriaBorrador> ConvocatoriasBorrador {get; set;}
        public DbSet<FormularioBorrador> FormulariosBorrador {get; set;}
         public DbSet<FormularioElementoBorrador> FormulariosElementosBorrador {get; set;}
        public DbSet<OpcRespuestaBorrador> OpcRespuestaBorrador {get; set;}
        public DbSet<ElementoFormularioBorrador> ElementoFormulariosBorrador {get; set;}
      
        /*FORMULARIO PUBLICADO*/
        public DbSet<ConvocatoriaPublicada> ConvocatoriasPublicadas {get; set;}
        public DbSet<FormularioPublicado> FormulariosPublicados {get; set;}
        public DbSet<OpcRespuestaPublicado> OpcRespuestasPublicados {get; set;}
        public DbSet<ElementoFormularioPublicado> ElementoFormulariosPublicados {get; set;}
        public DbSet<FormularioElementoPublicado> FormulariosElementosPublicados {get; set;}
        public DbSet<VersionFormularioPublicado> VersionFormularioPublicados {get; set;}

        /*BANCO FORMULARIOS*/
        public DbSet<BancoFormulario> BancoFormularios {get; set;}
        public DbSet<BancoElementoFormulario> BancoElementoFormularios {get; set;}
        public DbSet<BancoFormularioElemento> BancoFormularioElementos {get; set;}
        public DbSet<BancoOpcResElemento> BancoOpcRespuestas {get; set;}

         /*USUARIO*/
        public DbSet<Jurado> Jurados {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}


         /*PROPUESTA*/
        public DbSet<Respuesta> Respuestas {get; set;}

        public DbSet<EstadoPropuesta> EstadosPropuestas {get; set;}
        public DbSet<Propuesta> Propuestas {get; set;}
        public DbSet<PropuestaComentario> PropuestaComentarios {get; set;}
        public DbSet<UsuarioPropuesta> UsuarioPropuestas {get; set;}
        public DbSet<VersionP> Versiones {get; set;}
  

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