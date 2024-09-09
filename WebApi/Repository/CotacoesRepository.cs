using Microsoft.EntityFrameworkCore;
using WebApi.Infraestrutura;
using WebApi.Model;
using WebApi.Repository.Interface;

namespace WebApi.Repository
{
    public class CotacoesRepository : ICotacoesRepository
    {
        private readonly Conexao _contexto;
        public CotacoesRepository(Conexao _contexto)
        {
            this._contexto = _contexto;
        }

        //lista todos as cotações de todos os usuarios
        public async Task<IEnumerable<Cotacoes>> GetCotacoes()
        {
            return await _contexto.Cotacoes.ToListAsync();
        }

        //lista de contação por id
        public async Task<Cotacoes> GetCotacao(int idCotacao)
        {
            return await _contexto.Cotacoes.FirstOrDefaultAsync(e => e.idCotacao == idCotacao);
        }

        public async Task<Cotacoes> AddCotacoes(Cotacoes cotacoes)
        {
            var result = await _contexto.Cotacoes.AddAsync(cotacoes);
            await _contexto.SaveChangesAsync();
            return result.Entity;
        }

    }
}
