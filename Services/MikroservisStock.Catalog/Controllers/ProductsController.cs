using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MikroservisStock.Catalog.CatalogServices.ProductServices;
using MikroservisStock.Catalog.Dtos.ProductDtos;

namespace MikroservisStock.Catalog.Controllers
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

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productService.GetAllProductAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateProductAsync(createProductDto);
            return Ok("Ekleme başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return Ok("Silme başarılı");
        }

        [HttpGet("GetProduct")]
        public async Task<IActionResult> GetProduct(string id)
        {
            var value = await _productService.GetProductByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return Ok("Güncelleme başarılı");
        }
    }
}
