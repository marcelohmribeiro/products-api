namespace Products.Routes;

public static class ProductRoute
{
    public static void ProductRoutes(this WebApplication app)
    {
        app.MapGet("/", () => "Welcome to the API!");
    }
}