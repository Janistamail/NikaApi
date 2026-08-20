using NikaApi.Data;
using NikaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace NikaApi.Services;

public class CategoryService : ICategoryService
{
    private readonly AppDbContext _context;

    public CategoryService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Category>> GetCategoriesAsync()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category?> GetCategoryByIdAsync(int id)
    {
        return await _context.Categories.FindAsync(id);
    }

    public async Task<Category> CreateCategoryAsync(Category category)
    {
        var result = await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

}
