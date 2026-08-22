using NikaApi.DTOs.Products;
using NikaApi.Models;

namespace NikaApi.Services;

public interface IProductService
{
    Task<Product?> GetProductByIdAsync(int id);
    Task<Product> CreateProductAsync(CreateProductRequest request);
}
