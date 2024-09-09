using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using WebApi.Repository;
using WebApi.Repository.Interface;
using WebApi.ViewModel;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository _usuarioRepository)
        {
            this._usuarioRepository = _usuarioRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Usuario>> getUsuario(int id)
        {
            try
            {
                var result = await _usuarioRepository.GetUsuarioById(id);
                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao recuperar dados do banco de dados");
            }
        }



        [HttpPost]
        public async Task<ActionResult<Usuario>> createUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario == null) return BadRequest();

                var result = await _usuarioRepository.AddUsuario(usuario);

                return CreatedAtAction(nameof(getUsuario), new { id = result.idUsuario }, result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao adicionar dados no banco de dados");
            }
        }

        [HttpGet("cotacoes/{idUsuario:int}")]
        public async Task<ActionResult<IEnumerable<Cotacoes>>> GetCotacoesByIdUsuario(int idUsuario)
        {
            try
            {
                var cotacoes = await _usuarioRepository.GetCotacoesByIdUsuario(idUsuario);
                if (!cotacoes.Any()) // Verifica se a lista de cotações está vazia
                {
                    return NotFound($"Nenhuma cotação encontrado para o Usuario ID: {idUsuario}");
                }
                return Ok(cotacoes);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao recuperar dados do banco de dados");
            }
        }
    }
}
