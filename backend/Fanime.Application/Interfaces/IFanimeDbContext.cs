using System.Threading;
using System.Threading.Tasks;

namespace Fanime.Application.Interfaces
{
    public interface IFanimeDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
