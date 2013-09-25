using Domain.Core;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Security
{
    public interface IAuthenticationRepository
    {
        Authentication AddAuthentication(Authentication authentication);

        Authentication UpdateAuthentication(Authentication authentication);

        Authentication DeleteAuthentication(Authentication authentication);

        Authentication GetAuthentication(Authentication authentication);
    }
}
