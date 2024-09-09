using WebApi.Model;

namespace WebApi.Repository.Interface
{
    public class ICotacoesRepository
    {
        Task<Cotacoes>AddCotacoes(Cotacoes cotacoes);
    }
}
