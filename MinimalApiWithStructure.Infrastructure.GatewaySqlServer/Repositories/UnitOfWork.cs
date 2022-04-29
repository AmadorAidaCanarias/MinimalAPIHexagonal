using MinimalApiWithStructure.Enterprise.Domain.Interfaces.Repositories;
using MinimalApiWithStructure.Gateways.Infrastructure.GatewaySqlServer.DataContext;

namespace MinimalApiWithStructure.Gateways.Infrastructure.GatewaySqlServer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context) => _context = context;

        public Task<int> SaveChangesAssync(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
