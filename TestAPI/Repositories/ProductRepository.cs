using Microsoft.EntityFrameworkCore;
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
        Rating CreateRating(Rating rating);
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

        public Rating CreateRating(Rating rating)
        {
            _context.Ratings.Add(rating);
            _context.SaveChanges();
            return rating;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.Include(p => p.Ratings).ToList();
        }
    }
}
