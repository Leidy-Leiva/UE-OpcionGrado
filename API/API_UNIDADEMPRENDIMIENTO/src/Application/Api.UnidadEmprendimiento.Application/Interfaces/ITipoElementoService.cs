using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoFormulario;
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoPregunta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Application.Interfaces
{
    public interface ITipoElementoService
    {
        Task<List<GetTipoElementoDTO>> MostrarTiposPreguntas();
        Task<PostTipoElementoDTO> Registrar(PostTipoElementoDTO modelDTO);
        Task<bool> Actualizar(PutTipoElementoDTO modelDTO);

    }
}
