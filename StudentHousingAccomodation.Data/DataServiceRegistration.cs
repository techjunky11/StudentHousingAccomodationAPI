using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;
using StudentHousingAccomodation.Data.Data;

namespace StudentHousingAccomodation.Data
{
    public static class DataServiceRegistration
    {
        public static IServiceCollection ConfigureDataService(this IServiceCollection services, string connectionString) // Renamed parameter for clarity
        {

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Pass the connection string to UseSqlServer
            return services; // Ensure the method returns the IServiceCollection
        }
    }
}