using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DistributedServices.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "AuthenticationApi",
                routeTemplate: "api/authentications/{authentication}",
                defaults: new { controller = "Authentications", action = "Post" }
                );

            config.Routes.MapHttpRoute(
                name: "UsersApi",
                routeTemplate: "api/users",
                defaults: new { controller = "Users", action = "Get" }
                );
        }
    }
}
