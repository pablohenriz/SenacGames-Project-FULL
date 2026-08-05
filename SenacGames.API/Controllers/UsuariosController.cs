using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SenacGames.Application.DTOs;
using SenacGames.Application.Interfaces;

namespace SenacGames.API.Controllers
{
    [ApiController] // Define que esta classe responde a requisições HTTP (JSON)
    [Route("api/[controller]")] // A rota será: localhost:porta/api/usuarios
    [Authorize] // Exige que o cliente esteja logado com um token/cookie
    public class UsuariosController : ControllerBase
    {
        /*
         * DICA:
         * Note que usamos Tuplas (bool Success, UsuarioDto? Usuario, string ErrorMessage) como retorno. 
         * É uma prática muito boa do C# para retornar status da operação sem lançar Exceptions caríssimas a todo instante.
         */

        private readonly IUsuariosService _usuariosService;

        public UsuariosController(IUsuariosService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        [HttpGet] // GET /api/usuarios
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetAll()
        {
            var usuarios = await _usuariosService.GetAllAsync();
            return Ok(usuarios); // Retorna HTTP 200 com a lista em JSON
        }

        [HttpGet("{id}")] // GET /api/usuarios/{id}
        public async Task<ActionResult<UsuarioDto>> GetById(string id)
        {
            var usuario = await _usuariosService.GetByIdAsync(id);
            if (usuario == null)
                return NotFound(new { message = "Usuário não encontrado." });

            return Ok(usuario);
        }

        [HttpPost] // POST /api/usuarios
        public async Task<ActionResult<UsuarioDto>> Create([FromBody] CreateUsuarioDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var (success, usuario, error) = await _usuariosService.CreateAsync(dto);
            if (!success)
                return BadRequest(new { message = error }); // HTTP 400

            return CreatedAtAction(nameof(GetById), new { id = usuario?.Id }, usuario); // HTTP 201
        }

        [HttpPut("{id}")] // PUT /api/usuarios/{id}
        public async Task<ActionResult<UsuarioDto>> Update(string id, [FromBody] UpdateUsuarioDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var (success, usuario, error) = await _usuariosService.UpdateAsync(id, dto);
            if (!success)
                return BadRequest(new { message = error });

            return Ok(usuario);
        }

        [HttpDelete("{id}")] // DELETE /api/usuarios/{id}
        public async Task<IActionResult> Delete(string id)
        {
            var (success, error) = await _usuariosService.DeleteAsync(id);
            if (!success)
                return NotFound(new { message = error });

            return NoContent(); // HTTP 204
        }

        [HttpGet("perfis")] // GET /api/usuarios/perfis
        public async Task<ActionResult<IEnumerable<string>>> GetPerfis()
        {
            var perfis = await _usuariosService.GetPerfisAsync();
            return Ok(perfis);
        }
    }
}