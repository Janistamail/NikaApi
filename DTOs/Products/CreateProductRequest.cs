namespace NikaApi.DTOs.Products;

public class CreateProductRequest
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }
    public decimal? SalePrice { get; set; }
    public DateTime? SaleEndAt { get; set; }

    public int PreOrderDays { get; set; }

    public string Brand { get; set; } = string.Empty;
    public int WarrantyMonths { get; set; }

    public decimal Weight { get; set; }
    public string WeightUnit { get; set; } = "g";

    public decimal Length { get; set; }
    public decimal Width { get; set; }
    public decimal Height { get; set; }
    public string DimensionUnit { get; set; } = "cm";

    public string ShipsFromCountry { get; set; } = string.Empty;

    public int CategoryId { get; set; }

    public List<CreateProductImageRequest> Images { get; set; } = new();
}