using Products.Models;

namespace Products.Routes;

using System.Text.Json;

public static class ProductRoute
{
    public static void ProductRoutes(this WebApplication app)
    {
        app.MapGet("/", () => "Welcome to the API!");
        app.MapGet("/products", () =>
        {
            var json = File.ReadAllText("data/products.json");
            var products = JsonSerializer.Deserialize<List<ProductModel>>(json);
            return products;
        });
    }
}