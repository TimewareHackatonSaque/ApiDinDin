using WebApi.Model;

namespace WebApi.Repository.Interface
{
    public interface IUsuarioRepository
    {
        
        Task<Usuario> AddUsuario(Usuario usuario);

        Task<Usuario> GetUsuarioById(int id);
    }
}
