using Domain.Entities.Classes;
using Services.Abstractions;


namespace Services.Implementations
{
    public class UserGroupService : IUserGroupService
    {
        public Task<ICollection<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
