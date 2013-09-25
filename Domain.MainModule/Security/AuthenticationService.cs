using System;
using System.Collections.Generic;
using System.Linq;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Security
{
    public class AuthenticationService : IAuthenticationService
    {
    	readonly IAuthenticationRepository _authenticationRepository;

        public AuthenticationService(IAuthenticationRepository authenticationRepository)
        {
            _authenticationRepository = authenticationRepository;
        }

        public Authentication AddAuthentication(Authentication authentication)
        {
            return _authenticationRepository.AddAuthentication(authentication);
        }

        public Authentication UpdateAuthentication(Authentication authentication)
        {
            return _authenticationRepository.UpdateAuthentication(authentication);
        }

        public Authentication DeleteAuthentication(Authentication authentication)
        {
            return _authenticationRepository.DeleteAuthentication(authentication);
        }

        public Authentication GetAuthentication(Authentication authentication)
        {
            return _authenticationRepository.GetAuthentication(authentication);
        }
    }
}
