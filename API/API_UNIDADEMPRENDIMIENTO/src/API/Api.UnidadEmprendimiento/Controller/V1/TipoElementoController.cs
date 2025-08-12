using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoPregunta;
using Api.UnidadEmprendimiento.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Api.UnidadEmprendimiento.Controller.V1
{
    [Route("Api/V1/[controller]")]

    [ApiController]
    public class TipoElementoController : ControllerBase
    {

        private readonly ITipoElementoService _tipelemservice;

        public TipoElementoController(ITipoElementoService  tipeservice)
        {
            _tipelemservice= tipeservice;
        }

        // GET: api/<TipoPreguntaController>
        [HttpGet("GetAllTipoElementoFormulario")]
        public async Task<IActionResult> GetAll()
        {
            var tipelemento= await _tipelemservice.MostrarTiposPreguntas();
            return Ok(tipelemento);
        }

        // GET api/<TipoPreguntaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TipoPreguntaController>
        [HttpPost("PostTipoElementoFormulario")]
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
        // PUT api/<TipoPreguntaController>/5
        [HttpPut("{id}")]

        public async void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TipoPreguntaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
