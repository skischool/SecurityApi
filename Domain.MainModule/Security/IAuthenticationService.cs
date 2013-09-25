using System.Collections.Generic;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Security
{
    public interface IAuthenticationService
    {
        Authentication AddAuthentication(Authentication authentication);

        Authentication UpdateAuthentication(Authentication authentication);

        Authentication DeleteAuthentication(Authentication authentication);

        Authentication GetAuthentication(Authentication authentication);
    }
}
