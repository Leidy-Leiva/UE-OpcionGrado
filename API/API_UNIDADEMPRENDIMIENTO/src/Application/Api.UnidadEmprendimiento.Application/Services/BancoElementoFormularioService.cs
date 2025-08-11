using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.Pregunta;
using Api.UnidadEmprendimiento.Application.Interfaces;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Interfaces;
using AutoMapper;

namespace Api.UnidadEmprendimiento.Application.Services
{
    public class BancoElementoFormularioService : IBancoElementoFormularioService
    {
        private readonly IBancoElementoFormularioRepository _befrepository;
        private readonly IMapper _mapper;

        public BancoElementoFormularioService(IBancoElementoFormularioRepository befrepository, IMapper mapper)
        {
            _befrepository = befrepository;
            _mapper = mapper;
        }
        public async Task<PostBEFormularioDTO> Registrar(PostBEFormularioDTO modelDTO)
        {

            var beformulario = _mapper.Map<BancoElementoFormulario>(modelDTO);
            var creado = await _befrepository.PostBancoElemento(beformulario);
            if (!creado) throw new Exception("No se pudo crear el elemento");

            return modelDTO;
        }
        public Task<bool> Actualizar(PutBEFormularioDTO modelDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetBEFormularioDTO>> MostrarPreguntas()
        {
            var beformulario = await _befrepository.GetAllBancoElemento();
            return _mapper.Map<List<GetBEFormularioDTO>>(beformulario);
        }


    }
}