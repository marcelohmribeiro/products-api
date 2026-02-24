namespace Products.Models;

public class ProductModel
{
    public int Id { get; init; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; }  = string.Empty;
    public decimal Price { get; set; }
    public string Category { get; set; }  = string.Empty;
}
