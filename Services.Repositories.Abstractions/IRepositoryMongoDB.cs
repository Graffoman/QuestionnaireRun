using MongoDB.Bson;

namespace Services.Repositories.Abstractions
{
    public interface IRepositoryMongoDB<T>
    {
        IQueryable<T> GetAll(bool noTracking = false);
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken, bool asNoTracking = false);
        T Get(string id);
        Task<T> GetAsync(string id, CancellationToken cancellationToken);

        bool Delete(string id);
        Task<bool> DeleteAsync(string id, CancellationToken cancellationToken);

        bool Update(T entity);
        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken);

        T Add(T entity);
        Task AddAsync(T entity, CancellationToken cancellationToken);
    }
}
