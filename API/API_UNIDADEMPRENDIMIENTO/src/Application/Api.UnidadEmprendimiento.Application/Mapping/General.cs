using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoElementoFormulario;
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoOpcResElemento;
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoFormulario;
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoPregunta;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GES_BANCO_FORMULARIO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Application.Mapping
{
    public class General : Profile
    {
        public General()
        {
            #region commands
            CreateMap<PostTipoElementoDTO, TipoElementoFormulario>().ReverseMap();
            #endregion
            #region commands
            CreateMap<GetTipoElementoDTO, TipoElementoFormulario>().ReverseMap();
            #endregion

            #region commands
            CreateMap<PostTipoFormularioDTO, TipoFormulario>().ReverseMap();
            #endregion
            #region commands
            CreateMap<GetTipoFormularioDTO, TipoFormulario>().ReverseMap();
            #endregion

            CreateMap<BancoElementoFormulario, GetBEFormularioDTO>()
                .ForMember(dest => dest.TEFO_CODIGO, opt => opt.MapFrom(src => src.TEFO_CODIGO))
                .ForMember(dest => dest.BEFO_ENUNCIADO, opt => opt.MapFrom(src => src.BEFO_ENUNCIADO))
                .ForMember(dest => dest.BANCOOPCRESELEMENTOS, opt => opt.MapFrom(src => src.BANCOOPCRESELEMENTOS));

            CreateMap<PostBEFormularioDTO, BancoElementoFormulario>()
                .ForMember(dest => dest.BEFO_ENUNCIADO, opt => opt.MapFrom(src => src.BEFO_ENUNCIADO))
                .ForMember(dest => dest.TEFO_CODIGO, opt => opt.MapFrom(src => src.TEFO_CODIGO))
                .ForMember(dest => dest.BANCOOPCRESELEMENTOS, opt => opt.MapFrom(src => src.BANCOOPCRESELEMENTOS))
                .ForMember(dest => dest.TIPOELEMENTOF, opt => opt.Ignore()); // 👈 clave

            CreateMap<PostBORElementoDTO, BancoOpcResElemento>();


            CreateMap<BancoOpcResElemento, GetBORElementoDTO>();


        }
    }
}
