using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Data
{
    public class ApplicationUnit : IDisposable
    {
        private DataContext _context = new DataContext();

        private IRepository<User> _users = null;

        public IRepository<User> Users
        {
            get
            {
                if (this._users == null)
                {
                    this._users = new GenericRepository<User>(this._context);
                }

                return this._users;
            }
        }

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }

        public void Dispose()
        {
            if (this._context != null)
            {
                this._context.Dispose();
            }
        }
    }
}
