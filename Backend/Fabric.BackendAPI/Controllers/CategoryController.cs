using Fabric.BAL.Catalog.Categories;
using Microsoft.AspNetCore.Mvc;

namespace Fabric.BackendAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllCategories();
            return Ok(categories);
        }
    }
}
