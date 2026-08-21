
namespace NikaApi.Services;

public interface IProductService
{
    Task<Product?> GetProductByIdAsync(int id);
}
