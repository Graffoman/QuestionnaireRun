using Domain.Entities.Classes;
using Services.Contracts.Group;
using Services.Contracts.UserDto;
using Services.Contracts.UserGroupDto;

namespace Services.Abstractions
{
    public interface IUserGroupService
    {
        Task<List<UserGroup>> GetAllAsync();
        //Task<UserGroup> GetByIdAsync(string id);
        //Task<string> CreateAsync(CreateUserGroupDto createUserGroupDto);
        //Task<bool> UpdateAsync(UserGroup userGroup);
        //Task<bool> DeleteByIdAsync(string id);
        //Task<string> DeleteAsync(UserGroup userGroup);

        Task<UserGroup> GetByIdAsync(string id);

        Task<string> CreateAsync(CreateUserGroupDto createGroupDto);

        Task<bool> UpdateAsync(string id, UpdateUserGroupDto updateGroupDto);

        Task<bool> DeleteAsync(string id);

        Task<ICollection<UserGroupDto>> GetListAsync();

        Task<ICollection<UserDto>> GetUserListAsync(string id);
    }
}
