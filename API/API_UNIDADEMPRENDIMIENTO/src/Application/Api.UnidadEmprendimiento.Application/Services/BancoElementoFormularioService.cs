
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoElementoFormulario;
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoOpcResElemento;
using Api.UnidadEmprendimiento.Application.Enums;
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

        public async Task<List<GetBEFormularioDTO>> MostrarPreguntas()
        {
            var beformulario = await _befrepository.GetAllBancoElemento();
            return _mapper.Map<List<GetBEFormularioDTO>>(beformulario);
        }
        public async Task<PostBEFormularioDTO> Registrar(PostBEFormularioDTO modelDTO)
        {

            var tipo = (TipoElemento)modelDTO.TEFO_CODIGO;
            if (!tipo.IsQuestionType())
            {
                throw new InvalidOperationException("sólo acepta elementos de tipo PREGUNTA.");
            }
            if (tipo == TipoElemento.Abierta)
            {
                modelDTO.BANCOOPCRESELEMENTOS = new List<PostBORElementoDTO>();
            }
            if (modelDTO.BANCOOPCRESELEMENTOS != null)
            {
                for (int i = 0; i < modelDTO.BANCOOPCRESELEMENTOS.Count; i++)
                {
                    if (modelDTO.BANCOOPCRESELEMENTOS[i].BORE_ORDEN == null || modelDTO.BANCOOPCRESELEMENTOS[i].BORE_ORDEN == 0)
                        modelDTO.BANCOOPCRESELEMENTOS[i].BORE_ORDEN = i + 1;
                }
            }
            if (modelDTO.BEFO_ORDEN == 0)
            {
                modelDTO.BEFO_ORDEN = await _befrepository.GetNextOrdenForType(modelDTO.TEFO_CODIGO);
            }


            var beformulario = _mapper.Map<BancoElementoFormulario>(modelDTO);
            var creado = await _befrepository.PostBancoElemento(beformulario);
            if (!creado) throw new Exception("No se pudo crear el elemento");

            return modelDTO;
        }
        public async Task<bool> Actualizar(PutBEFormularioDTO modelDTO)
        {
            var beformulario = _mapper.Map<BancoElementoFormulario>(modelDTO);
            return await _befrepository.PutBancoElemento(beformulario);
        }




    }
}