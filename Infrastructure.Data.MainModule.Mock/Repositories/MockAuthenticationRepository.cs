using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.MainModule.Security;
using Domain.MainModule.Entities;

namespace Infrastructure.Data.MainModule.Mock.Repositories
{
    public class MockAuthenticationRepository : IAuthenticationRepository
    {
        public Authentication AddAuthentication(Authentication authentication)
        {
            return new Authentication()
            {
                Username = authentication.Username,
                Password = authentication.Password
            };
        }

        public Authentication UpdateAuthentication(Authentication authentication)
        {
            return new Authentication()
            {
                Username = authentication.Username,
                Password = authentication.Password
            };
        }

        public Authentication DeleteAuthentication(Authentication authentication)
        {
            return new Authentication()
            {
                Username = authentication.Username,
                Password = authentication.Password
            };
        }

        public Authentication GetAuthentication(Authentication authentication)
        {
            return new Authentication()
            {
                Username = authentication.Username,
                Password = authentication.Password
            };
        }
    }
}
