namespace Products.Models;

public class ProductModel
{
    public ProductModel(string name, string description, decimal price, string category)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Price = price;
        Category = category;
    }
    public Guid Id { get; init; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public string Category { get; private set; }

    public void ChangeProduct(string name, string description, decimal price, string category)
    {
        Name = name;
        Description = description;
        Price = price;
        Category = category;
    }
}
