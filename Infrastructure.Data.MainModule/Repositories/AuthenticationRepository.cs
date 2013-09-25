using System;
using System.Collections.Generic;
using System.Linq;
using Domain.MainModule.Security;
using Infrastructure.Data.MainModule.Context;
using Domain.MainModule.Entities;
using Domain.Core;


namespace Infrastructure.Data.MainModule.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
    	// readonly SecurityContext _context;

		public AuthenticationRepository()
        {
			// _context = new SecurityContext();
        }

        public Authentication AddAuthentication(Authentication authentication)
        {
            throw new NotImplementedException();
        }

        public Authentication UpdateAuthentication(Authentication authentication)
        {
            throw new NotImplementedException();
        }

        public Authentication DeleteAuthentication(Authentication authentication)
        {
            throw new NotImplementedException();
        }

        public Authentication GetAuthentication(Authentication authentication)
        {
            throw new NotImplementedException();
        }
    }
}
