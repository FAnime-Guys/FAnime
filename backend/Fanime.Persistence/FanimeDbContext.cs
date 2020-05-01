using Fanime.Application.Interfaces;
using Fanime.Domain.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Fanime.Persistence
{
    public class FanimeDbContext : DbContext, IFanimeDbContext
    {
        private readonly ICurrentUserService _currentUserService;

        public FanimeDbContext(DbContextOptions<FanimeDbContext> options) 
            : base(options)
        { }

        public FanimeDbContext(DbContextOptions<FanimeDbContext> options, ICurrentUserService currentUserService)
            : base(options)
        {
            _currentUserService = currentUserService;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(FanimeDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ChangeTracker.DetectChanges();

            foreach (var entity in ChangeTracker.Entries<AudtiableEntity>())
            {
                if (entity.State == EntityState.Added)
                {
                    entity.Entity.CreatedBy = _currentUserService.GetUsername();
                    entity.Entity.Created = DateTime.UtcNow;

                }
                else if (entity.State == EntityState.Modified)
                {
                    entity.Entity.LastModifiedBy = _currentUserService.GetUsername();
                    entity.Entity.LastModified = DateTime.UtcNow;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
