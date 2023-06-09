using Fabric.BAL.Catalog.Categories;
using Fabric.Data.EF;
using Fabric.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<FabricDBContext>(option =>
                option.UseSqlServer(builder.Configuration.GetConnectionString("FabricDatabase"))
            );
builder.Services.AddIdentity<User, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<FabricDBContext>()
                .AddDefaultTokenProviders();

builder.Services.AddTransient<ICategoryService, CategoryService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.UseSwagger();
app.UseSwaggerUI(option =>
{
    option.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    option.RoutePrefix = string.Empty;
    option.DocumentTitle = "My Swagger";
}
    );

app.Run();
