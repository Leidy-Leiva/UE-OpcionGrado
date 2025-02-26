using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoPregunta;
using Api.UnidadEmprendimiento.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.UnidadEmprendimiento.Controller.V1
{
    [Route("Api/V1/[controller]")]

    [ApiController]
    public class TipoPreguntaController : ControllerBase
    {

        private readonly ITipoPreguntaService _tiprservice;

        public TipoPreguntaController(ITipoPreguntaService tiprservice)
        {
            _tiprservice = tiprservice;
        }

        // GET: api/<TipoPreguntaController>
        [HttpGet("GetAllTipoPregunta")]
        public async Task<IActionResult> GetAll()
        {
            var tipreguntas= await _tiprservice.MostrarTiposPreguntas();
            return Ok(tipreguntas);
        }

        // GET api/<TipoPreguntaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TipoPreguntaController>
        [HttpPost("PostTipoPregunta")]
        public async Task<IActionResult> Post([FromBody] PostTipoPreguntaDTO model)
        {
            try
            {
                await _tiprservice.Registrar(model);
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
