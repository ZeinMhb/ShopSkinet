using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using core.Entities;
using core.Interfaces;


namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        private readonly IproductRepository _repo;
        public ProductsController(IproductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _repo.GetProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<Product?> GetProduct(int id)
        {
            return await _repo.GetProductByIdAsync(id);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product?>> GetProduct2(int id)
        {
            return await _repo.GetProductByIdAsync(id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct1(int id)
        {
            return Ok(await _repo.GetProductByIdAsync(id));
        }

    }
}