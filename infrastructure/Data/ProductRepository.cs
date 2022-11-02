using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Interfaces;

namespace infrastructure.Data
{
    public class ProductRepository : IproductRepository
    {
        private readonly StoreContext _context;
        public ProductRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.
         }
        Task<IReadOnlyList<Product>> GetProductsAsync()
        {

        }

    }
}