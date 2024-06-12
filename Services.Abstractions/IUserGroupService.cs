using Domain.Entities.Classes;
using Services.Contracts.UserDto;
using Services.Contracts.UserGroupDto;

namespace Services.Abstractions
{
    public interface IUserGroupService
    {
        Task<ICollection<User>> GetAllAsync();
        Task<User> GetByIdAsync(string id);
        Task<string> CreateAsync(CreateUserGroupDto createUserGroupDto);
        Task<string> UpdateAsync(UserGroup userGroup);
        Task<string> DeleteByIdAsync(string id);
        Task<string> DeleteAsync(UserGroup userGroup);
    }
}
