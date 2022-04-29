using Microsoft.AspNetCore.Mvc;
using MinimalApiWithStructure.Application.Domain.Dtos.ProductsDto;
using MinimalApiWithStructure.Application.Ports.InputPorts.Products;
using MinimalApiWithStructure.Application.Ports.OutputPorts.Products;
using MinimalApiWithStructure.Infrastructure.Controllers.Products;
using MinimalApiWithStructure.Infrastructure.InversionOfControl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddProjectDependencies(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
       new WeatherForecast
       (
           DateTime.Now.AddDays(index),
           Random.Shared.Next(-20, 55),
           summaries[Random.Shared.Next(summaries.Length)]
       ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.MapGet("/Products", async ([FromServices] IGetAllProductsInputPort _getAllProductInputPort, IGetAllProductsOuputPort _getAllProductsOutputPort) => {
    GetAllProductController getAllProductController = new(_getAllProductInputPort, _getAllProductsOutputPort);
    var Products = await getAllProductController.GetAllProducts();
    return Products;
    })
    .WithTags("Products");

app.MapPost("/Products", async ([FromServices] ICreateProductInputPort _createProductInputPort, ICreateProductOutputPort _createProductOutputPort, [FromBodyAttribute] CreateProductDto newProduct) => {
    CreateProductController getAllProductController = new(_createProductInputPort, _createProductOutputPort);
    var Product = await getAllProductController.CreateProduct(newProduct);
    return Product;
})
    .WithTags("Products");

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}