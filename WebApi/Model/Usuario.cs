using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Model
{

    [Table("usuarios")]
    public class Usuario
    {
        [Key]
        public int idUsuario { get;  set; }
        public string nome { get;  set; }
        public string telefone { get;  set; }
        public string email { get;  set; }
        public string cpf { get;  set; }
        public string senha { get;  set; }

        public int idCotacoes { get; set; }

        /*
        public Usuario(string nome, string telefone, string email, string cpf, string senha) {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.telefone = telefone;
            this.email = email;
            this.cpf = cpf;
            this.senha = senha;
        
        }*/

 
    }
}
