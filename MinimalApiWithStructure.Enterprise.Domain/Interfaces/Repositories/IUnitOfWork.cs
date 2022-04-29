namespace MinimalApiWithStructure.Enterprise.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAssync(CancellationToken cancellationToken);
    }
}
