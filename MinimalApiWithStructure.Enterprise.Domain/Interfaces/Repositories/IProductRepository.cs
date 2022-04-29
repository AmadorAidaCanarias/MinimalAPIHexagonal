using MinimalApiWithStructure.Enterprise.Domain.Entities;

namespace MinimalApiWithStructure.Enterprise.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IAddEntity<Product>, IGetAllEntity<Product>
    {

    }
}
