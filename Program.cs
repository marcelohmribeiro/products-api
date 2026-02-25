using Products.Data;
using Products.Routes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
// Injeção do banco de dados (sqlite)
builder.Services.AddScoped<ProductContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.ProductRoutes();

app.UseHttpsRedirection();
app.Run();
