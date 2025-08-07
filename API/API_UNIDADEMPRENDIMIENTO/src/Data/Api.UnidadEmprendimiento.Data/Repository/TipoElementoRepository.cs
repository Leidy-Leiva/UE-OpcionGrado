using Api.UnidadEmprendimiento.Data.Contexts;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.UnidadEmprendimiento.Data.Repository
{
    
    public class TipoElementoRepository:ITipoElementoRepository
    {
        private readonly ApplicationDbContext _context;

        public TipoElementoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> DeleteTipoElemento(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TipoElementoFormulario>> GetAllTipoElemento()
        {
            try 
            {
                var tipelemento= await _context.TipoElementosFormularios.ToListAsync();
                return tipelemento;
            }
            catch (Exception e) 
            {
                return new List<TipoElementoFormulario>();
            }
           
        }

        public TipoElementoFormulario GetTipoElemento(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> PostTipoElemento(TipoElementoFormulario model)
        {
            await _context.TipoElementosFormularios.AddAsync(model);
            return await _context.SaveChangesAsync() > 0;
        }

        public Task<bool> PutTipoElemento(TipoElementoFormulario model)
        {
            throw new NotImplementedException();
        }
    }
}
