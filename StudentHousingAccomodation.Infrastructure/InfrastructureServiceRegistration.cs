using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;
using System.Reflection;
using System.Text;

namespace StudentHousingAccomodation.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Register AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Bind JwtSection from configuration
            var jwtSection = configuration.GetSection("JwtSection").Get<JwtSection>();
            if (jwtSection == null)
            {
                throw new ArgumentNullException(nameof(jwtSection), "JwtSection configuration is missing.");
            }
            services.Configure<JwtSection>(configuration.GetSection("JwtSection"));

            services.AddLogging();
            services.AddMemoryCache();

            // Configure JWT authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSection.Issuer,
                    ValidAudience = jwtSection.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSection.Key!))
                };
            });

            services.AddCors(opt =>
            {
                opt.AddPolicy("AllowBlazorWasm",
                    builder => builder.WithOrigins("https://localhost:5001") // Replace with your Blazor WASM URL
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            // Dynamically register all repositories
            var assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract) // Get all non-abstract classes
                .ToList();

            foreach (var implementationType in types)
            {
                var interfaceType = implementationType.GetInterfaces()
                    .FirstOrDefault(i => i.Name == $"I{implementationType.Name}"); // Match interface by naming convention

                if (interfaceType != null)
                {
                    services.AddScoped(interfaceType, implementationType);
                }
            }

            return services;
        }
    }
}