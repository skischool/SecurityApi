using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Data
{
    public class UsersRepository 
    {
        private DataContext _context;

        public UsersRepository()
        {
            _context = new DataContext();
        }

       
    }
}
