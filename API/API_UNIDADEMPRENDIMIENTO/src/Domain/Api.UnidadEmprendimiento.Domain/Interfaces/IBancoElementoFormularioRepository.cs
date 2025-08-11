using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;

namespace Api.UnidadEmprendimiento.Domain.Interfaces
{
    public interface IBancoElementoFormularioRepository
    {
        Task<List<BancoElementoFormulario>> GetAllBancoElemento();
        BancoElementoFormulario GetBancoElemento(int id);
        Task<bool> PostBancoElemento(BancoElementoFormulario model);
        Task<bool> PutBancoElemento(BancoElementoFormulario model);
        Task<bool> DeleteBancoElemento(int id);

    }
}