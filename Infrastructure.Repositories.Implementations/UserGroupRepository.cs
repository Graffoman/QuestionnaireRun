using Domain.Entities.Classes;
using Infrastructure.DataAcess;
using Microsoft.EntityFrameworkCore;
using Services.Repositories.Abstractions;
using System.Linq;
using System.Text.RegularExpressions;

namespace Infrastructure.Repositories.Implementations
{
    public class UserGroupRepository : RepositoryPostgresDB<UserGroup, string>, IUserGroupRepository
    {
        public UserGroupRepository(PostgresDB db) : base(db){}

        public override async Task<UserGroup> GetAsync(string id, CancellationToken cancellationToken)
        {
            var query = Context.Set<UserGroup>().AsQueryable();

            return await query.SingleOrDefaultAsync(c => c.GroupId == id);
        }

        public async Task<List<UserGroup>> GetListAsync()
        {
            var query = GetAll()
                 .Where(c => !c.Deleted);
            return await query.ToListAsync();
        }

        public Task<List<User>> GetUserListAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
