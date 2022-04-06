using System.Collections.Generic;
using System.Linq;
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
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }
}
