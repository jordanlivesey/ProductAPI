using Common;
using Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Products_API.Models;
using Products_API.Repositories;
using Common.Extensions;
using Products_API.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Products_EF.Contexts.ProductsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped(typeof(IRepository<int, ProductModel>), typeof(ProductRepository));
builder.Services.AddScoped(typeof(IRepository<int, ProductModel>), typeof(ProductRepository));
builder.Services.WrapService(typeof(IRepository<int, ProductModel>), typeof(RepositoryLogger<int, ProductModel, ProductController>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
