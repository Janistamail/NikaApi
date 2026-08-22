using NikaApi.Data;
using Microsoft.EntityFrameworkCore;
using NikaApi.DTOs.Products;
using NikaApi.Models;

namespace NikaApi.Services;

public class ProductService : IProductService
{
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Product?> GetProductByIdAsync(int id)
    {
        return await _context.Products
            .Include(p => p.Category)
            .Include(p => p.Images)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<Product> CreateProductAsync(CreateProductRequest request)
    {
        var product = new Product
        {
            Name = request.Name,
            Description = request.Description,
            Price = request.Price,
            SalePrice = request.SalePrice,
            SaleEndAt = request.SaleEndAt,
            PreOrderDays = request.PreOrderDays,
            Brand = request.Brand,
            WarrantyMonths = request.WarrantyMonths,
            Weight = request.Weight,
            WeightUnit = request.WeightUnit,
            Length = request.Length,
            Width = request.Width,
            Height = request.Height,
            DimensionUnit = request.DimensionUnit,
            ShipsFromCountry = request.ShipsFromCountry,
            CategoryId = request.CategoryId
        };

        foreach (var image in request.Images)
        {
            product.Images.Add(new ProductImage
            {
                ImageUri = image.ImageUri,
                SortOrder = image.SortOrder
            });
        }

        _context.Products.Add(product);

        await _context.SaveChangesAsync();

        return product;
    }

}
