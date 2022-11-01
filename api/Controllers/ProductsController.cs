using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using infrastructure.Data;
using core.Entities;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<Product?> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product?>> GetProduct2(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct1(int id)
        {
            return Ok(await _context.Products.FindAsync(id));
        }

    }
}