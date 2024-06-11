using Domain.Entities.Classes;
using Infrastructure.DataAcess;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public class UserGroupRepository : RepositoryMongoDB<UserGroup>, IUserGroupRepository
    {
        public UserGroupRepository(MongoDB<UserGroup> db) : base(db)
        {

        }
    }
}
