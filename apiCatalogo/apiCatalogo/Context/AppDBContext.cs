using apiCatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace apiCatalogo.Context
{
    /*Essa classe é responsável por permitir coodernar a funcionalidade do entityFrameWork Core para o modelo de entidades*/
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
