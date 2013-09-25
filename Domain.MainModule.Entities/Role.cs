﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.MainModule.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; }

        public Role()
        {
            this.Users = new List<User>();
        }
    }
}
