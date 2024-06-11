using Domain.Entities.Classes;
using Services.Contracts.UserGroupDto;

namespace Services.Abstractions
{
    public interface IUserGroupService
    {
        Task<ICollection<User>> GetAllAsync();
        Task<User> GetByIdAsync(string id);
    }
}
