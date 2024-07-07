using Domain.Entities.Classes;
using Infrastructure.DataAcess;
using Microsoft.EntityFrameworkCore;
using Services.Repositories.Abstractions;
using System.Linq;

namespace Infrastructure.Repositories.Implementations
{
    public class UserRepository : RepositoryPostgresDB<User, string>, IUserRepository
    {
        public UserRepository(PostgresDB db) : base(db){}


        public override async Task<User> GetAsync(string id, CancellationToken cancellationToken)
        {
            var query = Context.Set<User>().AsQueryable();
            return await query.SingleOrDefaultAsync(c => c.Id == id);
        }

        //public async Task<List<UserGroup>> GetGroupListAsync(string id)
        //{
        //    var groups = Context.Set<UserGroup>().AsQueryable()
        //                    .Where(c => !c.Deleted);
        //    var usergroups = Context.Set<UserGroup>().AsQueryable()
        //                    .Where(c => c.UserId == id);

        //    List<string> groupSearchListIds = usergroups.Select(x => x.GroupId).ToList();

        //    groups = groups.Where(x => groupSearchListIds.Contains(x.Id));

        //    return await groups.ToListAsync();
        //}

        public async Task<List<User>> GetListAsync()
        {
            var query = GetAll()
                .Where(c => !c.Deleted);
            return await query.ToListAsync();
        }

    }
}