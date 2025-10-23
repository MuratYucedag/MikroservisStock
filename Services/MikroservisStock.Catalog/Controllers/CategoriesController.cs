using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MikroservisStock.Catalog.CatalogServices.CategoryServices;
using MikroservisStock.Catalog.Dtos.CategoryDtos;

namespace MikroservisStock.Catalog.Controllers
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

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryService.GetAllCategoryAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            await _categoryService.CreateCategoryAsync(createCategoryDto);
            return Ok("Ekleme başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(string id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return Ok("Silme başarılı");
        }

        [HttpGet("GetCategory")]
        public async Task<IActionResult> GetCategory(string id)
        {
            var value=await _categoryService.GetCategoryByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            await _categoryService.UpdateCategoryAsync(updateCategoryDto);
            return Ok("Kategori Güncellendi");
        }
    }
}
