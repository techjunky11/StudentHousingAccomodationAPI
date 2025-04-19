using Microsoft.Extensions.Configuration;
using StudentHousingAccomodation.Application;
using StudentHousingAccomodation.Data;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;
using StudentHousingAccomodation.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureApplicationServices();

// Safely retrieve the connection string and handle potential null values
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("The connection string 'DefaultConnection' is not configured.");
}
var jwtSection = builder.Configuration.GetSection(nameof(JwtSection)).Get<JwtSection>();
if (jwtSection == null)
{
    throw new InvalidOperationException("The JWT section is not configured.");
}
builder.Services.ConfigureDataService(connectionString); // Ensure the extension method is defined and accessible.

builder.Services.ConfigureInfrastructureServices(builder.Configuration); // Pass the required 'Configuration' argument.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowBlazorWasm");
app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();