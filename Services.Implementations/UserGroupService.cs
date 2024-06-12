using Domain.Entities.Classes;
using Services.Abstractions;
using Services.Contracts.UserGroupDto;


namespace Services.Implementations
{
    public class UserGroupService : IUserGroupService
    {
        public Task<string> CreateAsync(CreateUserGroupDto createUserGroupDto)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(UserGroup userGroup)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(UserGroup userGroup)
        {
            throw new NotImplementedException();
        }
    }
}
