﻿using Domain.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts.UserGroupDto
{
    /// <summary>
    /// ДТО Группы
    /// </summary>
    public class CreateUserGroupDto
    {
        /// <summary>
        /// Идентификатор группы.
        /// </summary>
        //public string Id { get; set; }

        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
