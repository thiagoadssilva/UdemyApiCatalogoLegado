using apiCatalogo.Context;
using apiCatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiCatalogo.Controllers
{
    [Route("api/[Controller]")] 
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProdutosController(AppDbContext contexto)
        {
            _context = contexto;    
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            return _context.Produtos.AsNoTracking().ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Produto> get(int id)
        {
            var produto = _context.Produtos.AsNoTracking().FirstOrDefault(p => p.ProdutoId == id);
            if(produto == null)
            {
                return NotFound();
            }
            return produto;
        }
    }
}
