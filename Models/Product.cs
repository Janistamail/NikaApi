using NikaApi.Models;
// namespace NikaApi.Models;

public class Product
{
    public int Id { get; set; }

    // Basic
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    // Price
    public decimal Price { get; set; }
    public decimal? SalePrice { get; set; }
    public DateTime? SaleEndAt { get; set; }

    // Product information
    public int PreOrderDays { get; set; }
    public int SoldCount { get; set; }
    public int ReviewCount { get; set; }

    // Shipping / physical information
    public string Brand { get; set; } = string.Empty;
    public int WarrantyMonths { get; set; }
    public decimal Weight { get; set; }
    public string WeightUnit { get; set; } = "g";

    public decimal Length { get; set; }
    public decimal Width { get; set; }
    public decimal Height { get; set; }
    public string DimensionUnit { get; set; } = "cm";

    public string ShipsFromCountry { get; set; } = string.Empty;

    // Category
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}