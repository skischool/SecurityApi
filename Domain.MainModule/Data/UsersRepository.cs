using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Data
{
    public class UsersRepository : Domain.MainModule.Data.IUsersRepository 
    {
        private UserContext _context;

        public UsersRepository()
        {
            _context = new UserContext();
        }

        public User GetUserBy(string username)
        {
            var users = _context.Users;
            
            var user = users.FirstOrDefault(u => u.Username == username);

            return user;
        }

       
    }
}
