using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DistributedServices.Web.Filters;
using Domain.MainModule.Entities;
using WebMatrix.WebData;

namespace DistributedServices.Web.Controllers
{
    [InitializeSimpleMembership]
    public class SecurityController : ApiController
    {
        // GET api/security?username&password
        public bool Get(string username, string password)
        {
            var result = WebSecurity.Login(username, password, persistCookie: true);

            return result;
        }

        // POST api/security
        public string Post(string username, string password, string clienttoken)
        {
            var result = WebSecurity.CreateUserAndAccount(username, password, new { ClientToken = Guid.Parse(clienttoken) });

            return result;
        }
    }
}
