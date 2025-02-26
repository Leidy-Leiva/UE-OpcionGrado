using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.TipoFormulario;
using Api.UnidadEmprendimiento.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.UnidadEmprendimiento.Controller.V1
{
    [Route("Api/V1/[controller]")]
    [ApiController]
    public class TipoFormularioController : ControllerBase
    {
        private readonly ITipoFormularioService _tformularioService;

        public TipoFormularioController(ITipoFormularioService formularioService)
        {
            _tformularioService = formularioService;
        }

        // GET: api/<TipoFormularioController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tipformulario= await _tformularioService.MostrarTiposFormularios();
            return Ok(tipformulario);
        }

        // GET api/<TipoFormularioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TipoFormularioController>
        [HttpPost("PostTipoFormulario")]
        public async Task<IActionResult> Post([FromBody] PostTipoFormularioDTO model)
        {
            try 
            {
                await _tformularioService.Registrar(model);
                return Ok(model);
            }
            catch (Exception e) 
            {
                return StatusCode(500, $"Internal server error:{e.Message}");
            }
        }

        // PUT api/<TipoFormularioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TipoFormularioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
