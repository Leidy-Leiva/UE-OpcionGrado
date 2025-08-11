using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;


namespace Api.UnidadEmprendimiento.Domain.Interfaces
{
    public interface ITipoElementoRepository
    {
        Task<List<TipoElementoFormulario>> GetAllTipoElemento();
        TipoElementoFormulario GetTipoElemento(int id); // Obtener una entidad por su ID
        Task<bool> PostTipoElemento(TipoElementoFormulario model);
        Task<bool> PutTipoElemento(TipoElementoFormulario model);
        Task<bool> DeleteTipoElemento(int id); // Eliminar una entidad por su ID
    }
}

