using NikaApi.Services;
using Microsoft.AspNetCore.Mvc;
using NikaApi.DTOs.Products;

namespace NikaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(int id)
    {
        var product = await _productService.GetProductByIdAsync(id);

        if (product is null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request)
    {
        var product = await _productService.CreateProductAsync(request);
        return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
    }

}