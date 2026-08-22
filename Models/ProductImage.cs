namespace NikaApi.Models;

public class ProductImage
{
    public int Id { get; set; } //PK


    public string ImageUri { get; set; } = null!;


    public int SortOrder { get; set; }
    public int ProductId { get; set; } //FK, Index
}

