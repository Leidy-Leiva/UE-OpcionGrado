using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Domain.Interfaces
{
    public interface ITipoPreguntaRepository
    {
        Task<List<TipoPregunta>> GetAllTipoPregunta();
        TipoPregunta GetTipoPregunta(int id); // Obtener una entidad por su ID
        Task<bool> PostTipoPregunta(TipoPregunta model);
        Task<bool> PutTipoPregunta(TipoPregunta model);
        Task<bool> DeleteTipoPregunta(int id); // Eliminar una entidad por su ID
    }
}

