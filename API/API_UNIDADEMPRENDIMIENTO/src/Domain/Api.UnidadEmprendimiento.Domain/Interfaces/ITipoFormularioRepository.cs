using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Domain.Interfaces
{
    public interface ITipoFormularioRepository
    {
        Task<List<TipoFormulario>> GetAllTipoFormulario();
        TipoFormulario GetTipoFormulario(int id); // Obtener una entidad por su ID
        Task<bool> PostTipoFormulario(TipoFormulario model);
        Task<bool> PutTipoFormulario(TipoFormulario model);
        Task<bool> DeleteTipoFormulario(int id); // Eliminar una entidad por su ID

    }
}
