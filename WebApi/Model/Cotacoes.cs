using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Enum;

namespace WebApi.Model
{
    
    [Table("cotacoes")]
    public class Cotacoes
    {
        [Key]
        public int idCotacoes { get; set; }
        public double valor { get; set; }
        public  Parcelas parcelas { get; set; }



    }
}
