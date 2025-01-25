using Microsoft.EntityFrameworkCore;
using SuppliersManagement.Application.Interfaces;
using SuppliersManagement.Application.Services;
using SuppliersManagement.Infrastructure.Contexts;
using SuppliersManagement.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependecy Injection
builder.Services.AddScoped<ISupplierService, SupplierService>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();

// Automapper
builder.Services.AddAutoMapper(typeof(Program));

// AppDbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Swagger configuration
builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Suppliers Management API",
        Version = "v1",
        Description = "API para gestionar proveedores (CRUD básico)",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Renato Arredondo Vela",
            Email = "renato.avela.17@gmail.com"
        }
    });
});


// Cors Configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy("DevCors", app =>
    {
        app.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseGlobalExceptionsHandler();

app.UseHttpsRedirection();

app.UseCors("DevCors");

app.UseAuthorization();

app.MapControllers();

app.Run();
