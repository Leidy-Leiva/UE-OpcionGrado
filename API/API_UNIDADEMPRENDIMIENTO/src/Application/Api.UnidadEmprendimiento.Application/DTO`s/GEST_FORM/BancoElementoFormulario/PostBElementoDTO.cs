using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoElementoFormulario
{
    public class PostBElementoDTO
    {
        public string? BEFO_ENUNCIADO { get; set; }
        public int? BEFO_ORDEN { get; set; }
        public bool? BEFO_ESTADO { get; set; }
        public int TEFO_CODIGO { get; set; }
        public string? BEFO_DATOSJSON { get; set; }
        public int TIPOELEMENTOF { get; set; }

        // public required TipoElementoFormulario TIPOELEMENTOF { get; set; }
        // public ICollection<BancoOpcResElemento> BANCOOPCRESELEMENTOS { get; set; } = new List<BancoOpcResElemento>();
        // public ICollection<BancoFormularioElemento> BFORMULARIOSE { get; set; } = new List<BancoFormularioElemento>();






    }
}
