using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoPregunta;
using Api.UnidadEmprendimiento.Application.Interfaces;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Interfaces;
using AutoMapper;

namespace Api.UnidadEmprendimiento.Application.Services
{
    public class TipoElementoService : ITipoElementoService
    {
        private readonly ITipoElementoRepository _tiprrepository;
        private readonly IMapper _mapper;

        public TipoElementoService(ITipoElementoRepository tiprrepository, IMapper mapper)
        {
            _tiprrepository = tiprrepository;
            _mapper = mapper;
        }

        public async Task<PostTipoElementoDTO> Registrar(PostTipoElementoDTO modelDTO)
        {
            var tipopregunta = _mapper.Map<TipoElementoFormulario>(modelDTO);
            await _tiprrepository.PostTipoElemento(tipopregunta);
            return modelDTO;
        }
        public Task<bool> Actualizar(PutTipoElementoDTO modelDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetTipoElementoDTO>> MostrarTiposPreguntas()
        {
            var tipreguntas = await _tiprrepository.GetAllTipoElemento();
            return _mapper.Map<List<GetTipoElementoDTO>>(tipreguntas);
        }
    }
}
