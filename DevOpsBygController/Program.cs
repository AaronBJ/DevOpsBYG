
using BygDevOpsData.Data;
using BygDevOpsData.inventoryRepository;
using BygDevOpsData.InventoryTagsManager;
using BygDevOpsData.Models;
using BygDevOpsData.tagsRepository;
using BygDevOpsManager.inventory;
using BygModels.inventory;
using BygModels.inventoryTags;
using BygModels.tags;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddTransient<IInventoryManager, InventoryManager>();//inyeccion de dependencia del inventory manager
builder.Services.AddTransient<IInventoryRepository, InventoryRepository>();
builder.Services.AddTransient<ITagsRepository, TagsRepository>();
builder.Services.AddTransient<IInventoryTagsRepository, InventoryTagsRepository>();
builder.Services.AddOpenApi();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("Default"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("Default"))
        ));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.OpenApiInfo
    {

        Title = "myAPI",
        Version = "v1"

    });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");

app.UseAuthorization();
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");

});
app.MapControllers();



app.Run();
