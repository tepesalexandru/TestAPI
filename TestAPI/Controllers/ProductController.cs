using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Business;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductManager _productManager;
        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productManager.GetProducts());
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            return Ok(_productManager.CreateProduct(product));
        }
    }
}
