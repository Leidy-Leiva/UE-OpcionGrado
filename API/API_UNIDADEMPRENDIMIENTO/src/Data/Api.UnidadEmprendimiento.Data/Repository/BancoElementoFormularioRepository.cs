using Api.UnidadEmprendimiento.Data.Contexts;
using Api.UnidadEmprendimiento.Domain.Interfaces;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Microsoft.EntityFrameworkCore;


namespace Api.UnidadEmprendimiento.Data.Repository
{
    public class BancoElementoFormularioRepository : IBancoElementoFormularioRepository
    {
        private readonly ApplicationDbContext _context;

        public BancoElementoFormularioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> DeleteBancoElemento(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BancoElementoFormulario>> GetAllBancoElemento()
        {
            try
            {
                var beformulario = await _context.BancoElementoFormularios
                    .Include(be => be.BANCOOPCRESELEMENTOS)
                    .ToListAsync();
                return beformulario;
            }
            catch (Exception e)
            {
                return new List<BancoElementoFormulario>();
            }
        }

        public async Task<BancoElementoFormulario> GetBancoElemento(int id)
        {

            var beformulario = await _context.BancoElementoFormularios
         .Include(be => be.BANCOOPCRESELEMENTOS)
         .Include(be => be.TIPOELEMENTOF)
         .FirstOrDefaultAsync(be => be.BEFO_CODIGO == id);

            return beformulario;

        }

        public async Task<bool> PostBancoElemento(BancoElementoFormulario model)
        {
            await _context.BancoElementoFormularios.AddAsync(model);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> PutBancoElemento(BancoElementoFormulario model)
        {
            _context.Update(model);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}