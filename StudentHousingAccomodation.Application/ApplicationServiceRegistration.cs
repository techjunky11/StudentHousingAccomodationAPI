using MediatR;
using Microsoft.Extensions.DependencyInjection;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;
using StudentHousingAccomodation.Infrastructure.Repositories.Implementations;
using System.Reflection;

namespace StudentHousingAccomodation.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection Services)
        {
            Services.AddMediatR(Assembly.GetExecutingAssembly());
            // Explicitly register the ope
            var assembly = Assembly.GetExecutingAssembly();

            Services.AddAutoMapper(assembly);

            Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            // Dynamically register other repositories
            var types = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract) // Get all non-abstract classes
                .ToList();

            foreach (var implementationType in types)
            {
                var interfaceType = implementationType.GetInterfaces()
                    .FirstOrDefault(i => i.Name == $"I{implementationType.Name}"); // Match interface by naming convention

                if (interfaceType != null)
                {
                    Services.AddScoped(interfaceType, implementationType);
                }
            }

            return Services;
        }
    }
}