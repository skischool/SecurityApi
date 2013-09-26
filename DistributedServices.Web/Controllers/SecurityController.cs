using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DistributedServices.Web.Filters;
using Domain.MainModule.Data;
using Domain.MainModule.Entities;
using WebMatrix.WebData;

namespace DistributedServices.Web.Controllers
{
    [InitializeSimpleMembership]
    public class SecurityController : ApiController
    {
        private IUsersRepository _repository = new UsersRepository();
        
        // GET api/security?username&password
        public User Get(string username, string password)
        {
            var result = WebSecurity.Login(username, password, persistCookie: true);

            if (result)
            {
                var user = _repository.GetUserBy(username);

                return user;
            }

            return new User() { Id = 0 };
        }

        // POST api/security
        public string Post(string username, string password, string clienttoken)
        {
            var result = WebSecurity.CreateUserAndAccount(username, password, new { ClientToken = Guid.Parse(clienttoken) });

            return result;
        }
    }
}
