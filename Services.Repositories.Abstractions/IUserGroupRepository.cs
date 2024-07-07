using Domain.Entities.Classes;

namespace Services.Repositories.Abstractions
{
    public interface IUserGroupRepository : IRepositoryPostgresDB<UserGroup, string>
    {
        Task<List<UserGroup>> GetListAsync();

        //Task<bool> DeleteByIdAsync(string id);

        Task<List<User>> GetUserListAsync(string id);
    }
}
