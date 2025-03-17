using System.Collections.Generic;
using System.Threading;
using PYD_service_DAL.Models;

namespace PYD_service_DAL.Repositories.Interfaces
{
    public interface IPYDRepository
    {
        Task<long> CreateAsync(
            PYD pyd,
            CancellationToken cancellationToken);

        Task<List<PYD>> GetAsync(
            long[] ids,
            CancellationToken cancellationToken);
    }
}
