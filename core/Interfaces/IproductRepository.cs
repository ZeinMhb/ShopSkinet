using System;
using System.Collections.Generic;
using System.Linq;
using core.Entities;
using System.Threading.Tasks;

namespace core.Interfaces
{
    public interface IproductRepository
    {
        Task<Product?> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}