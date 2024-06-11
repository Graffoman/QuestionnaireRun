using Domain.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositories.Abstractions
{
    public interface IUserRepository : IRepositoryPostgresDB<User, string>
    {
        Task <List<User>> GetUsers(string id);
    }
}
