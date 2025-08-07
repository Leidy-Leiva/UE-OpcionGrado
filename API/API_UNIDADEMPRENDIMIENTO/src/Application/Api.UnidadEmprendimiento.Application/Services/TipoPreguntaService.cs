using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoPregunta;
using Api.UnidadEmprendimiento.Application.Interfaces;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Interfaces;
using AutoMapper;

namespace Api.UnidadEmprendimiento.Application.Services
{
    public class TipoPreguntaService : ITipoPreguntaService
    {
        private readonly ITipoPreguntaRepository _tiprrepository;
        private readonly IMapper _mapper;

        public TipoPreguntaService(ITipoPreguntaRepository tiprrepository, IMapper mapper)
        {
            _tiprrepository = tiprrepository;
            _mapper = mapper;
        }

        public async Task<PostTipoPreguntaDTO> Registrar(PostTipoPreguntaDTO modelDTO)
        {
            var tipopregunta = _mapper.Map<TipoPregunta>(modelDTO);
            await _tiprrepository.PostTipoPregunta(tipopregunta);
            return modelDTO;
        }
        public Task<bool> Actualizar(PutTipoPreguntaDTO modelDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetTipoPreguntaDTO>> MostrarTiposPreguntas()
        {
            var tipreguntas = await _tiprrepository.GetAllTipoPregunta();
            return _mapper.Map<List<GetTipoPreguntaDTO>>(tipreguntas);
        }
    }
}
