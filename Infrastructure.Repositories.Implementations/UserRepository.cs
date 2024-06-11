using Domain.Entities.Classes;
using Infrastructure.DataAcess;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public class UserRepository : RepositoryPostgresDB<User, string>, IUserRepository
    {
        public UserRepository(PostgresDB db) : base(db)
        {

        }

        public Task<User> AddAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(List<User> entities)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(ICollection<User> entities)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRange(ICollection<User> entities)
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(string id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUsers(string id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        void IRepositoryPostgresDB<User, string>.Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}