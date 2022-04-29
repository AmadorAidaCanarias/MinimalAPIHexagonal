using MinimalApiWithStructure.Enterprise.Domain.Entities;
using MinimalApiWithStructure.Enterprise.Domain.Interfaces.Repositories;
using MinimalApiWithStructure.Gateways.Infrastructure.GatewaySqlServer.DataContext;

namespace MinimalApiWithStructure.Gateways.Infrastructure.GatewaySqlServer.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) => _context = context;

        public void Add(Product entity)
        {
            _context.Products.Add(entity);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
