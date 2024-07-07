
using Domain.Entities.Interfaces;

namespace Services.Repositories.Abstractions
{
    public interface IRepositoryPostgresDB<T, TPrimaryKey>
        where T : IEntityPostgresDB<TPrimaryKey>
    {
        IQueryable<T> GetAll(bool noTracking = false);
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken, bool asNoTracking = false);
        T Get(TPrimaryKey id);
        Task<T> GetAsync(TPrimaryKey id, CancellationToken cancellationToken);
        bool Delete(TPrimaryKey id);
        bool Delete(T entity);
        bool DeleteRange(ICollection<T> entities);
        bool Update(T entity);
        Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken);
        T Add(T entity);
        Task<T> AddAsync(T entity);
        void AddRange(List<T> entities);
        Task AddRangeAsync(ICollection<T> entities);
        void SaveChanges();
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }

}