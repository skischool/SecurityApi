using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.MainModule.Data;
using Domain.MainModule.Entities;

namespace DistributedServices.Api.Controllers
{
    public class UsersController : ApiController
    {
        private ApplicationUnit _unit = new ApplicationUnit();
        
        // GET api/secutity/
        public HttpResponseMessage GetAll()
        {
            var users = _unit.Users.GetAll();

            return Request.CreateResponse(HttpStatusCode.OK, users.ToList());
        }

        // GET api/users/username?password
        public HttpResponseMessage Get(string username, string password)
        {
            return null;
        }
    }
}
