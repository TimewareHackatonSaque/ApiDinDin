using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using WebApi.Repository.Interface;

namespace WebApi.Controllers
{
    public class CotacoesController : Controller
    {
        private readonly ICotacoesRepository _cotacoesRepository;

        public CotacoesController(ICotacoesRepository _cotacoesRepository)
        {
            this._cotacoesRepository = _cotacoesRepository;
        }

        [HttpGet]
        public async Task<ActionResult> getCotacao()
        {
            try
            {
                return Ok(await _cotacoesRepository.GetContacoes());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao recuperar dados do banco de dados");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Cotacoes>> AddCotacoes([FromBody] Cotacoes cotacoes)
        {
            try
            {
                if (cotacoes == null) return BadRequest();

                var result = await _cotacoesRepository.AddCotacoes(cotacoes);

                return CreatedAtAction(nameof(getCotacao), new { id = result.idCotacao }, result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao adicionar dados no banco de dados");
            }
        }

        
    }
}
