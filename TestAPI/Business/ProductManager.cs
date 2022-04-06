using System.Collections.Generic;
using TestAPI.Models;
using TestAPI.Repositories;

namespace TestAPI.Business
{
    public interface IProductManager
    {
        List<Product> GetProducts();
        Product CreateProduct(Product product);
    }

    public class ProductManager : IProductManager
    {
        private readonly IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product CreateProduct(Product product)
        {
            return _productRepository.CreateProduct(product);
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }
    }

}
