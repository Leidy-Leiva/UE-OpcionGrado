using Api.UnidadEmprendimiento.Data.Contexts;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.UnidadEmprendimiento.Data.Repository
{
    
    public class TipoPreguntaRepository:ITipoPreguntaRepository
    {
        private readonly ApplicationDbContext _context;

        public TipoPreguntaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> DeleteTipoPregunta(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TipoPregunta>> GetAllTipoPregunta()
        {
            try 
            {
                var tipreguntas= await _context.TiposPreguntas.ToListAsync();
                return tipreguntas;
            }
            catch (Exception e) 
            {
                return new List<TipoPregunta>();
            }
           
        }

        public TipoPregunta GetTipoPregunta(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> PostTipoPregunta(TipoPregunta model)
        {
            await _context.TiposPreguntas.AddAsync(model);
            return await _context.SaveChangesAsync() > 0;
        }

        public Task<bool> PutTipoPregunta(TipoPregunta model)
        {
            throw new NotImplementedException();
        }
    }
}
