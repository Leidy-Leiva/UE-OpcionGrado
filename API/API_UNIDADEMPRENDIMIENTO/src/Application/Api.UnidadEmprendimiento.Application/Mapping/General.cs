using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoFormulario;
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoPregunta;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Application.Mapping
{
    public class General: Profile
    {
        public General() 
        {

            #region commands
            CreateMap<PostTipoPreguntaDTO, TipoPregunta>().ReverseMap();
            #endregion
            #region commands
            CreateMap<GetTipoPreguntaDTO, TipoPregunta>().ReverseMap();
            #endregion

            #region commands
            CreateMap<PostTipoFormularioDTO, TipoFormulario>().ReverseMap();
            #endregion
            #region commands
            CreateMap<GetTipoFormularioDTO, TipoFormulario>().ReverseMap();
            #endregion




        }
    }
}
