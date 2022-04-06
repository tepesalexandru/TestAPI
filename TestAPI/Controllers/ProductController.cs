using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
        [Route("getAll")]
        public IActionResult GetAll()
        {
            return Ok(_productManager.GetProducts());
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Product product)
        {
            return Ok(_productManager.CreateProduct(product));
        }

        [HttpPost]
        [Route("review")]
        public IActionResult ReviewProduct(Guid productId, int rating)
        {
            return Ok(_productManager.ReviewProduct(productId, rating));
        }
    }
}
