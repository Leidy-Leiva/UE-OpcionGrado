using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Domain.Interfaces
{
    public interface IEstadoPropuestaRepository
    {
        Task<List<EstadoPropuesta>> GetAllEstadoPropuesta();
        EstadoPropuesta GetEstadoPropuesta(int id); // Obtener una entidad por su ID
        Task<bool> PostEstadoPropuesta(EstadoPropuesta model);
        Task<bool> PutEstadoPropuesta(EstadoPropuesta model);
        Task<bool> DeleteEstadoPropuesta(int id); // Eliminar una entidad por su ID
    }
}
