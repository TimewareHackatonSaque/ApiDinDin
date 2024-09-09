using Microsoft.EntityFrameworkCore;
using WebApi.Infraestrutura;
using WebApi.Model;
using WebApi.Repository.Interface;

namespace WebApi.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Conexao _contexto;
        public UsuarioRepository(Conexao _contexto)
        {
            this._contexto = _contexto;
        }

        public async Task<Usuario> AddUsuario(Usuario usuario)
        {
            var result = await _contexto.Usuarios.AddAsync(usuario);
            await _contexto.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Usuario> GetUsuarioById(int id)
        {
            return await _contexto.Usuarios.FirstOrDefaultAsync(e => e.id == id);
        }
    }
}
