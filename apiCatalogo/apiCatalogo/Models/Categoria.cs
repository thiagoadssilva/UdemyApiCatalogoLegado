namespace apiCatalogo.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }     
        public string Nome { get; set; }
        public string Descricao { get; set; } 
        public string ImagemUrl { get; set; }
        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
