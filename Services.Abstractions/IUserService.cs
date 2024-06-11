using Domain.Entities.Classes;
using Services.Contracts.UserDto;


namespace Services.Abstractions
{
    public interface IUserService
    {
        Task<ICollection<User>> GetAllAsync();
        Task<User> GetByIdAsync(string id);
        Task<string> CreateAsync(CreateUserDto CreateUserDto);
        Task<string> UpdateAsync(User user);
        Task<string> DeleteByIdAsync(string id);
        Task<string> DeleteAsync(User user);
    }
}
