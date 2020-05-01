using Fanime.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fanime.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IFanimeDbContext, FanimeDbContext>(options =>
                options.UseMySQL(configuration.GetConnectionString("FanimeDatabase"), options => options.MigrationsHistoryTable("ef_migrations")));

            return services;
        }
    }
}
