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
            return await _contexto.Usuarios.FirstOrDefaultAsync(e => e.idUsuario == id);
        }



        public async Task<IEnumerable<Cotacoes>> GetCotacoesByIdUsuario(int idUsuario)
        {
            var usuario = await _contexto.Usuarios.FindAsync(idUsuario);

            if (usuario == null)
            {
                return Enumerable.Empty<Cotacoes>(); // Retorna uma lista vazia se não existir a cotação
            }

            // Caso exista retorna a lista de cotações do usuário
            return await _contexto.Cotacoes
                .Where(e => e.idUsuario == idUsuario)
                .ToListAsync();
        }

      
    }
}
