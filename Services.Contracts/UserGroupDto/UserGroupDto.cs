﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts.UserGroupDto
{
    public class UserGroupDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
    }
}