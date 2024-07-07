using Services.Contracts.Group;
using Services.Contracts.UserDto;


namespace Services.Abstractions
{
    public interface IUserService
    {
        //Task<List<User>> GetAllAsync();
        //Task<User> GetByIdAsync(string id);
        //Task<string> CreateAsync(CreateUserDto createUserDto);
        //Task<string> UpdateAsync(User user);
        //Task<string> DeleteByIdAsync(string id);
        //Task<string> DeleteAsync(User user);

        /// <summary>
        /// Получить пользователя.
        /// </summary>
        /// <param name="id"> Идентификатор. </param>
        /// <returns> ДТО пользователя. </returns>
        Task<UserDto> GetByIdAsync(string id);
        Task<string> CreateAsync(CreateUserDto createUserDto);
        Task UpdateAsync(string id, UpdateUserDto updateUserDto);
        Task DeleteAsync(string id);

        /// <summary>
        /// Получить полный список.
        /// </summary>
        /// <returns> Список пользователей. </returns>
        //Task<ICollection<UserDto>> GetListAsync();

        ///// <summary>
        ///// Получить список групп пользователя.
        ///// </summary>
        ///// <param name="id"> Идентификатор. </param>
        ///// <returns> Список групп пользователя. </returns>
        //Task<ICollection<GroupDto>> GetGroupListAsync(string id);
    }
}
