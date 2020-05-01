using Microsoft.EntityFrameworkCore;
using Fanime.Persistence.Infrastructure;

namespace Fanime.Persistence
{
    public class FanimeDbContextFactory : DesignTimeDbContextFactoryBase<FanimeDbContext>
    {
        protected override FanimeDbContext CreateNewInstance(DbContextOptions<FanimeDbContext> options)
        {
            return new FanimeDbContext(options);
        }
    }
}
