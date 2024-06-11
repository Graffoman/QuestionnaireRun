using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts.UserDto
{
    /// <summary>
    /// ДТО юзера
    /// </summary>
    public class CreateUserDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
