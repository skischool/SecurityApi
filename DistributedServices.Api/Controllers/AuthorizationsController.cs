using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DistributedServices.Api.Controllers
{
    public class AuthorizationsController : ApiController
    {
        // GET api/authorization
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/authorization/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/authorization
        public void Post([FromBody]string value)
        {
        }

        // PUT api/authorization/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/authorization/5
        public void Delete(int id)
        {
        }
    }
}
