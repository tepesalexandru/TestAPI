using System.Collections.Generic;
using TestAPI.Context;
using TestAPI.Models;

namespace TestAPI.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product CreateProduct(Product product);
    }
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _context;
        public ProductRepository(DatabaseContext context)
        {
            _context = context;
        }
        public Product CreateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
