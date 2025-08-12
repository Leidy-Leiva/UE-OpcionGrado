using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.Respuesta;

namespace Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.Pregunta
{
    public class GetBEFormularioDTO
    {
        public string? BEFO_ENUNCIADO { get; set; }
        public string TEFO_CODIGO { get; set; }
        public List<GetBORElementoDTO> BANCOOPCRESELEMENTOS { get; set; }
    }
}
