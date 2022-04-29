namespace MinimalApiWithStructure.Enterprise.Domain.Interfaces.Repositories
{
    public interface IAddEntity<TEntity>
    {
        void Add(TEntity entity);
    }
}
