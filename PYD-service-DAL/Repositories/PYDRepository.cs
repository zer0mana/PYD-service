using System.Collections.Generic;
using System.Threading;
using LinqToDB;
using LinqToDB.Tools;
using PYD_service_DAL.LinqToDb;
using PYD_service_DAL.Models;
using PYD_service_DAL.Repositories.Interfaces;

namespace PYD_service_DAL.Repositories
{
    public class PYDRepository : IPYDRepository
    {
        private readonly ApplicationDbContext _context;

        public PYDRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<long> CreateAsync(PYD pyd, CancellationToken cancellationToken)
        {
            var id = await _context.PYDQuery.InsertWithInt64IdentityAsync(
                () => new PYD
                {
                    Name = pyd.Name,
                    Description = pyd.Description,
                    AuthorId = pyd.AuthorId,
                    GoalPoints = pyd.GoalPoints,
                    AddedAt = pyd.AddedAt
                }, 
                cancellationToken);
            return id;
        }

        public async Task<List<PYD>> GetAsync(long[] ids, CancellationToken cancellationToken)
        {
            return await _context.PYDQuery.Where(p => p.Id.In(ids)).ToListAsync(cancellationToken);
        }
    }
}
