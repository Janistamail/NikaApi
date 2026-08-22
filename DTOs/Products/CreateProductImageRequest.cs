namespace NikaApi.DTOs.Products;

public class CreateProductImageRequest
{
    public string ImageUri { get; set; } = null!;

    public int SortOrder { get; set; }

}