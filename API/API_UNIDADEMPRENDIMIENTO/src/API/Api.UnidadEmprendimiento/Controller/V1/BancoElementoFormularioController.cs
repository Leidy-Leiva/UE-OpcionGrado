using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoElementoFormulario;
using Api.UnidadEmprendimiento.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.UnidadEmprendimiento.Controller.V1
{
    [Route("Api/V1/[controller]")]
    [ApiController]
    public class BancoElementoFormularioController : ControllerBase
    {
        private readonly IBancoElementoFormularioService _befservice;

        public BancoElementoFormularioController(IBancoElementoFormularioService befservice)
        {
            _befservice = befservice;
        }

           // GET: api/<TipoPreguntaController>
        [HttpGet("GetAllBancoElemelemnto")]
        public async Task<IActionResult> GetAll()
        {
            var bancoElemento= await _befservice.Mos();
            return Ok(bancoElemento);
        }

        // GET api/<TipoPreguntaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TipoPreguntaController>
        [HttpPost("PostBancoElemelemnto")]
        public async Task<IActionResult> Post([FromBody] PostTipoElementoDTO model)
        {
            try
            {
                Console.WriteLine($"Valor recibido: {model.TPEF_NOMBRE}"); // Debug
                await _tipelemservice.Registrar(model);
                return Ok(model);
            }catch (Exception e)
            {
                return StatusCode(500, $"Internal server error:{e.Message}");
            }
        }
       
        [HttpPut("{id}")]

        public async void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
