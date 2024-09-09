using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Repository.Interface
{
    public interface ICotacoesRepository
    {

        Task<IEnumerable<Cotacoes>> GetContacoes();

        Task<Cotacoes>AddCotacoes(Cotacoes cotacoes);


        Task<Cotacoes> GetContacao(int IdCotacao);
    }

    
}
