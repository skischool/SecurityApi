using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.MainModule.Entities;
using Domain.MainModule.Security;
using Infrastructure.CrossCutting.IoC;

namespace DistributedServices.Api.Controllers
{
    public class AuthenticationsController : ApiController
    {
        private readonly IAuthenticationService _authenticationService;
        
        public AuthenticationsController()
        {
            _authenticationService = IoCFactory.Resolve<IAuthenticationService>();
        }
          
        // GET api/authentications/5
        public HttpResponseMessage Get([FromUri]Authentication authentication)
        {
            var getAuthenticationRequest = new Authentication() { Username = authentication.Username, Password = authentication.Password };

            var getAuthenticationResponse = _authenticationService.GetAuthentication(getAuthenticationRequest);

            return Request.CreateResponse(HttpStatusCode.OK, getAuthenticationResponse);
        }

        // POST api/authentications
        public HttpResponseMessage Post([FromBody]Authentication authentication)
        {
            var addAuthenticationRequest = new Authentication() { Username = authentication.Username, Password = authentication.Password };

            var addAuthenticationResponse = _authenticationService.AddAuthentication(addAuthenticationRequest);

            return Request.CreateResponse(HttpStatusCode.OK, addAuthenticationResponse);
        }

        // PUT api/authentications/5
        public HttpResponseMessage Put([FromBody]Authentication authentication)
        {
            var updateAuthenticationRequest = new Authentication() { Username = authentication.Username, Password = authentication.Password };

            var updateAuthenticationResponse = _authenticationService.UpdateAuthentication(updateAuthenticationRequest);

            return Request.CreateResponse(HttpStatusCode.OK, updateAuthenticationResponse);
        }

        // DELETE api/authentications/
        public HttpResponseMessage Delete([FromBody]Authentication authentication)
        {
            var deleteAuthenticationRequest = new Authentication() { Username = authentication.Username, Password = authentication.Password };

            var deleteAuthenticationResponse = _authenticationService.DeleteAuthentication(deleteAuthenticationRequest);

            return Request.CreateResponse(HttpStatusCode.OK, deleteAuthenticationResponse);
        }
    }
}
