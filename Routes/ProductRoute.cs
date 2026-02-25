using Microsoft.EntityFrameworkCore;
using Products.Data;
using Products.Models;

namespace Products.Routes;

public static class ProductRoute
{
    public static void ProductRoutes(this WebApplication app)
    {
        app.MapGet("/", () => "Welcome to the API!");
        app.MapPost("/products", async (ProductRequest req, ProductContext context) =>
        {
            var product = new ProductModel(req.name, req.description, req.price, req.category);
            await context.AddAsync(product);
            await context.SaveChangesAsync();
        });
        app.MapGet("/products", async (ProductContext context) =>
        {
            var product = await context.Product.ToListAsync();
            if (product is null)
                return Results.NotFound();
            
            return Results.Ok(product);
        });
        app.MapPut("/products/{id:guid}", async (Guid id, ProductRequest req, ProductContext context) =>
        {
            var product = await context.Product.FindAsync(id);
            if (product is null)
                return Results.NotFound();
            
            product.ChangeProduct(req.name, req.description, req.price, req.category);
            await context.SaveChangesAsync();
            
            return Results.Ok(product);
        });
        app.MapDelete("/products/{id:guid}", async (Guid id, ProductContext context) =>
        {
            var product = await context.Product.FindAsync(id);
            if (product is null)
                return Results.NotFound();

            context.Product.Remove(product);
            await context.SaveChangesAsync();
            return Results.Ok("Produto removido");
        });
    }
}