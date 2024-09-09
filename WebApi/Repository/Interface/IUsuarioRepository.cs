using WebApi.Model;

namespace WebApi.Repository.Interface
{
    public interface IUsuarioRepository
    {
        
        Task<Usuario> AddUsuario(Usuario usuario);

        Task<IEnumerable<Usuario>> GetCotacoesByIdUsuario(int idUsuario); // Busca as cotacoes pelo id do Usuario

        Task<Usuario> GetUsuarioById(int idUsuario);
    }
}
