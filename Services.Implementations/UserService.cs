using Domain.Entities.Classes;
using Services.Abstractions;
using Services.Contracts.UserDto;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        public Task<string> CreateAsync(CreateUserDto CreateUserDto)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(User user)
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

        public Task<string> UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
