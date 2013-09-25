using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DistributedServices.Api.Controllers
{
    public class SecurityController : ApiController
    {
        // GET api/security
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/security/5
        public bool Get(string username, string password, string clientToken)
        {

            
            return true;
        }

        // POST api/security
        public void Post([FromBody]string value)
        {
        }

        // PUT api/security/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/security/5
        public void Delete(int id)
        {
        }
    }
}
