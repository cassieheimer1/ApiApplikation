using ApiApplikation.Models.Forms;
using ApiApplikation.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiApplikation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductForm form)
        {
            var product = await _productService.CreateAsync(form);
            if(product != null)
                return new OkObjectResult(product);

            return new BadRequestResult();
        }
    }
}
