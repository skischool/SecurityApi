using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.MainModule.Entities
{
    public class User
    {
        public int Id { get; set; }
        public Guid ClientToken { get; set; }
        public string Username { get; set; }

        public ICollection<Role> Roles { get; set; }

        public User()
        {
            this.Roles = new List<Role>();
        }
    }
}
