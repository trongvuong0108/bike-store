using BikeShop.Application.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BikeShop.BackendAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductService productService { set; get; } 
        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(productService.GetProducts());
        }
    }
}
