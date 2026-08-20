using NikaApi.Models;

namespace NikaApi.Services;

public interface ICategoryService
{
    Task<List<Category>> GetCategoriesAsync();
    Task<Category?> GetCategoryByIdAsync(int id);
    Task<Category> CreateCategoryAsync(Category category);
}