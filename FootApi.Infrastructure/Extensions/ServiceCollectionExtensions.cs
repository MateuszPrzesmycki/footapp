using FootApi.Infrastructure.DbConextMain;
using FootApi.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FootApi.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FootApiDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("FootConnectionString")));
            services.AddScoped<IClubSeeder, ClubSeeder>();
        }
    }
}
