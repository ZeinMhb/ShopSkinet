using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Interfaces;

namespace infrastructure.Data
{
    public class ProductRepository : IproductRepository
    {
        Task<Product> GetProductByIdAsync(int id)
        {

        }
        Task<IReadOnlyList<Product>> GetProductsAsync()
        {

        }

    }
}