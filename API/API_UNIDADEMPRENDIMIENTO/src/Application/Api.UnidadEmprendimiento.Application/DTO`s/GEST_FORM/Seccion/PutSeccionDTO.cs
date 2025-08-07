using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.Seccion
{
    public class PutSeccionDTO
    {
        public string SECC_NOMBRE { get; set; }
        public int SECC_ORDEN { get; set; }
        public int FORM_CODIGO { get; set; }
        public bool SECC_ESTADO {  get; set; }
    }
}
