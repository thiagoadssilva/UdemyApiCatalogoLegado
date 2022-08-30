using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiCatalogo.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        /*Sempre que tiver uma definição de coleção, temos que definir a inicialização dessa coleção
         dentro de um construtor, geralmente isso não é feito, mas como uma boa pratica*/
        
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }        
        [MaxLength(300)]
        public string Descricao { get; set; }
        [Required]
        [MaxLength(300)]
        public string ImagemUrl { get; set; }
        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }
        /*Aqui estou criando um relacionamento entre categoria e produto*/
        public ICollection<Produto> Produtos { get; set; }
    }
}
