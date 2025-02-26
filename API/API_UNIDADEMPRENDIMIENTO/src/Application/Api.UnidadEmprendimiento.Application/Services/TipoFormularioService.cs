using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoFormulario;
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoPregunta;
using Api.UnidadEmprendimiento.Application.Interfaces;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Application.Services
{
    public class TipoFormularioService : ITipoFormularioService
    {
        private readonly ITipoFormularioRepository _tipfrepository;
        private readonly IMapper _mapper;

        public TipoFormularioService(ITipoFormularioRepository tipfrepository, IMapper mapper)
        {
            _tipfrepository = tipfrepository;
            _mapper = mapper;
        }

        public async Task<List<GetTipoFormularioDTO>> MostrarTiposFormularios()
        {
            var tiformularios = await _tipfrepository.GetAllTipoFormulario();
            return _mapper.Map<List<GetTipoFormularioDTO>>(tiformularios);
        }
        public async Task<PostTipoFormularioDTO> Registrar(PostTipoFormularioDTO modelDTO)
        {
            var tipoformulario = _mapper.Map<TipoFormulario>(modelDTO);
            await _tipfrepository.PostTipoFormulario(tipoformulario);

            return modelDTO;
        }

        public Task<bool> Actualizar(PutTipoFormularioDTO modelDTO)
        {
            throw new NotImplementedException();
        }
    }
}
