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
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Идентификатор юзера.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// почта юзера
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Имя юзера.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия юзера.
        /// </summary>
        public string LastName { get; set; }

    }
}
