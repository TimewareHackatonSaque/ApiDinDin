using WebApi.Model;

namespace WebApi.Repository.Interface
{
    public interface IUsuarioRepository
    {
        
        Task<Usuario> AddUsuario(Usuario usuario);

        Task<IEnumerable<Cotacoes>> GetCotacoesByIdUsuario(int idUsuario); // Busca as cotacoes pelo id do Usuario

        Task<Usuario> GetUsuarioById(int idUsuario);
    }
}
