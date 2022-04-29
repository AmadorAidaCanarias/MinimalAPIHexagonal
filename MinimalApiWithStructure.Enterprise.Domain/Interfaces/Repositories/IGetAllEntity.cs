namespace MinimalApiWithStructure.Enterprise.Domain.Interfaces.Repositories
{
    public interface IGetAllEntity<TEntity>
    {
        IEnumerable<TEntity> GetAll();
    }
}
