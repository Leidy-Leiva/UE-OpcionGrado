using Api.UnidadEmprendimiento.Data.Contexts;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Data.Repository
{
    public class TipoFormularioRepository : ITipoFormularioRepository
    {
        private readonly ApplicationDbContext _context;

        public TipoFormularioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> DeleteTipoFormulario(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TipoFormulario>> GetAllTipoFormulario()
        {
            try 
            {
                var tiformularios =await _context.TiposFormularios.ToListAsync();
                return tiformularios;
            }catch(Exception e) 
            {
                return new List<TipoFormulario>();
            }

           
        }

        public TipoFormulario GetTipoFormulario(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> PostTipoFormulario(TipoFormulario model)
        {
            await _context.TiposFormularios.AddAsync(model);
            return await _context.SaveChangesAsync() > 0;
            
        }

        public Task<bool> PutTipoFormulario(TipoFormulario model)
        {
            throw new NotImplementedException();
        }
    }
}
