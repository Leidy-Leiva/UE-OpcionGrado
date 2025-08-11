using Api.UnidadEmprendimiento.Data.Contexts;
using Api.UnidadEmprendimiento.Domain.Interfaces;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Microsoft.EntityFrameworkCore;


namespace Api.UnidadEmprendimiento.Data.Repository
{
    public class BancoElementoFormularioRepository: IBancoElementoFormularioRepository
    {
        private readonly ApplicationDbContext _context;
        public Task<bool> DeleteBancoElemento(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BancoElementoFormulario>> GetAllBancoElemento()
        {
            throw new NotImplementedException();
        }

        public BancoElementoFormulario GetBancoElemento(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostBancoElemento(BancoElementoFormulario model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutBancoElemento(BancoElementoFormulario model)
        {
            throw new NotImplementedException();
        }
    }
}