using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using NetTechnicalTest_Template.Repositories;
using NetTechnicalTest_Template.Services;
using System;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ProductService>();
    })
    .Build();

var service = host.Services.GetRequiredService<ProductService>();
var products = service.GetProducts();

foreach (var product in products)
{
    Console.WriteLine($"{product.Id} - {product.Name} - {product.Price}");
}
