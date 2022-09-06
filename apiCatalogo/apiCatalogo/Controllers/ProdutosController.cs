using apiCatalogo.Context;
using apiCatalogo.Models;
using Microsoft.AspNetCore.Mvc;

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
            return _context.Produtos.ToList();
        }
    }
}
