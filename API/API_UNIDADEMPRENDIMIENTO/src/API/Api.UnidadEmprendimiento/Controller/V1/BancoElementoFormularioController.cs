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


        [HttpGet("GetAllBancoElemento")]
        public async Task<IActionResult> GetAll()
        {
            var lista = await _befservice.MostrarPreguntas();
            return Ok(lista);
        }

        [HttpPost("PostBancoElemento")]
        public async Task<IActionResult> Create([FromBody] PostBEFormularioDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errors = ModelState });

            try
            {
                var result = await _befservice.Registrar(dto);
                return Created("", result);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error interno" });
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutBEFormularioDTO dto)
        {
            var actualizado = await _befservice.Actualizar(dto);
            return actualizado ? Ok() : BadRequest();
        }
    }
}