using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }


    }
}
