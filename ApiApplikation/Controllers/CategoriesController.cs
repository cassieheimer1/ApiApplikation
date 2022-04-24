using ApiApplikation.Models.Forms;
using ApiApplikation.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiApplikation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryForm form)
        {
            var category = await _categoryService.CreateAsync(form);

            if(category != null)
            return new OkObjectResult(category);

            return new BadRequestResult();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return new OkObjectResult(await _categoryService.GetAllAsync());
        }
    }
}
