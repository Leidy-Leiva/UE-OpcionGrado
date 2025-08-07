using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoPregunta;
using Api.UnidadEmprendimiento.Application.Interfaces;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Interfaces;
using AutoMapper;

namespace Api.UnidadEmprendimiento.Application.Services
{
    public class TipoElementoService : ITipoElementoService
    {
        private readonly ITipoElementoRepository _teforepository;
        private readonly IMapper _mapper;

        public TipoElementoService(ITipoElementoRepository teforepository, IMapper mapper)
        {
            _teforepository = teforepository;
            _mapper = mapper;
        }

        public async Task<PostTipoElementoDTO> Registrar(PostTipoElementoDTO modelDTO)
        {
              Console.WriteLine($"Antes de mapear: {modelDTO.TPEF_NOMBRE}"); // Debug
            var tipoelemento = _mapper.Map<TipoElementoFormulario>(modelDTO);
                Console.WriteLine($"Después de mapear: {tipoelemento.TPEF_NOMBRE}"); // Debug

            await _teforepository.PostTipoElemento(tipoelemento);
            return modelDTO;
        }
        public Task<bool> Actualizar(PutTipoElementoDTO modelDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetTipoElementoDTO>> MostrarTiposPreguntas()
        {
            var tipoelemento = await _teforepository.GetAllTipoElemento();
            return _mapper.Map<List<GetTipoElementoDTO>>(tipoelemento);
        }
    }
}
