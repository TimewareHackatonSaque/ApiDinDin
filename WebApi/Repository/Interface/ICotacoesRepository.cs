using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Repository.Interface
{
    public interface ICotacoesRepository
    {

        Task<IEnumerable<Cotacoes>> GetCotacoes();

        Task<Cotacoes>AddCotacoes(Cotacoes cotacoes);


        Task<Cotacoes> GetCotacao(int IdCotacao);
    }

    
}
