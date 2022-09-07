using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiCatalogo.Migrations
{
    public partial class migracaoInicialBancoDois : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO apialunosdb01.categorias (Nome, ImagemUrl) VALUES('Bebidas', 'bebidas.jpg')");
            mb.Sql("INSERT INTO apialunosdb01.categorias (Nome, ImagemUrl) VALUES('Lanches', 'lanches.jpg')");
            mb.Sql("INSERT INTO apialunosdb01.categorias (Nome, ImagemUrl) VALUES('Sobremesas', 'sobremesas.jpg')");

            mb.Sql("INSERT INTO apialunosdb01.produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES('Coca-cola', 'Refrigerante', 50, 'cocacola.jpg', 50, now(), " +
                "(select CategoriaId  from categorias where Nome = 'Bebidas'))");
            mb.Sql("INSERT INTO apialunosdb01.produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES('Bolo', 'Doce', 55, 'bolo.jpg', 10, now(), " +
                "(select CategoriaId  from categorias where Nome = 'Lanches'))");
            mb.Sql("INSERT INTO apialunosdb01.produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES('Sorvete', 'muito bom', 25, 'sorvete.jpg', 15, now(), " +
                "(select CategoriaId  from categorias where Nome = 'Sobremesas'))");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM produtos");
            mb.Sql("DELETE FROM categorias");
        }
    }
}
