using Domain.Entities.Classes;

namespace Services.Repositories.Abstractions
{
    public interface IUserRepository : IRepositoryPostgresDB<User, string>
    {
        //Task <List<User>> GetUsers(string id);
        Task<List<User>> GetListAsync();

        /// <summary>
        /// Получить список групп пользователя.
        /// </summary>
        /// <param name="id"> Идентификатор. </param>
        /// <returns> Список групп. </returns>
        //Task<List<UserGroup>> GetGroupListAsync(string id);
    }
}
