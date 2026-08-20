using NikaApi.Services;
using NikaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace NikaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCategories()
    {
        var categories = await _categoryService.GetCategoriesAsync();

        return Ok(categories);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
        var category = await _categoryService.GetCategoryByIdAsync(id);

        if (category is null)
        {
            return NotFound();
        }

        return Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory(Category category)
    {
        var createdCategory = await _categoryService.CreateCategoryAsync(category);

        return CreatedAtAction(nameof(GetCategoryById), new { id = createdCategory.Id }, createdCategory);
    }
}